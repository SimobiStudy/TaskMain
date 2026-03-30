using MessagePack;
using MessagePack.Formatters;
using MessagePack.Resolvers;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Task7.Main;
using Task7.Main.Actions;
using Task7.Main.Figures;

namespace Task7;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        typeof(Panel).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic)?.SetValue(panelCanvas, true);


    }

    private CanvasInfo canvasInfo = new CanvasInfo();

    private PreviousActionsStorer previousActionStorer = new PreviousActionsStorer(25);

    private string _filePath = string.Empty;

    private void panelCanvas_Paint(object sender, PaintEventArgs e)
    {
        DrawGrid(e.Graphics, panelCanvas.Size);

        foreach (var figure in canvasInfo.ActiveFigures.AsEnumerable().Reverse())
        {
            figure.DrawFigure(e.Graphics, figure.Location, figure.Size);
        }

        if (selectedFigure != null && canvasInfo.ActiveFigures.Contains(selectedFigure))
        {
            markers.AddMarkers(e.Graphics, selectedFigure);
        }

    }

    private void DrawGrid(Graphics g, Size containerSize, int cellSize = 50)
    {
        using (Pen gridPen = new Pen(Color.FromArgb(60, 20, 20, 20), 1))
        {

            for (int x = 0; x <= containerSize.Width; x += cellSize)
            {
                g.DrawLine(gridPen, x, 0, x, containerSize.Height);
            }

            for (int y = 0; y <= containerSize.Height; y += cellSize)
            {
                g.DrawLine(gridPen, 0, y, containerSize.Width, y);
            }
        }
    }

    private void InitiateAction(IFigureAction action)
    {
        previousActionStorer._list.Push(action);
        action.Execute();
        panelCanvas.Invalidate();
    }

    private void RollbackAction()
    {
        var action = previousActionStorer._list.Pop();
        action.Undo();
        panelCanvas.Invalidate();
    }

    #region File handlers

    private void SaveFile(bool requestPath = false)
    {
        if (!File.Exists(_filePath) || requestPath)
            if (GetFilePath(false) == null)
                return;

        try
        {
            File.WriteAllBytes(_filePath, canvasInfo.SerializeToBytes());
            panelCanvas.Invalidate();
        }
        catch (Exception ex)
        {
            MessageBox.Show(@"Failed to save file. " + ex.Message);
            _filePath = string.Empty;
        }
    }

    private void OpenFile()
    {
        try
        {
            canvasInfo.SerializeFromBytes(File.ReadAllBytes(GetFilePath(true, false)));
            panelCanvas.Invalidate();
        }
        catch (Exception ex)
        {
            MessageBox.Show(@"Failed to open file. " + ex.Message);
            _filePath = string.Empty;
        }

    }

    private string GetFilePath(bool isOpen, bool shouldSave = true)
    {
        FileDialog fileDialog = isOpen ? (FileDialog)openFileInfo : saveFileInfo;

        DialogResult dialogResult = fileDialog.ShowDialog();
        if (DialogResult.OK != dialogResult) return null;

        if (shouldSave)
            _filePath = fileDialog.FileName;
        return fileDialog.FileName;
    }

    #endregion

    #region ActionsHelper

    private Figure? CheckHit(Point point)
    {
        foreach (var figure in canvasInfo.ActiveFigures)
        {
            if (figure.HitTest(point))
            {
                return figure;
            }
        }
        return null;
    }

    #endregion

    private Point? previousMousePosition = null;

    private void panelCanvas_MouseMove(object sender, MouseEventArgs e)
    {
        OnSelectionResizeMove(e);
        OnHoldMoved(e);
        previousMousePosition = e.Location;
    }

    private void panelCanvas_MouseDown(object sender, MouseEventArgs e)
    {
        previousMousePosition = e.Location;
        OnSelectionResizeStart(e);
        OnHoldStarted(e);
    }

    private void panelCanvas_MouseUp(object sender, MouseEventArgs e)
    {
        OnSelectionResizeEnd(e);
        OnHoldEnded(e);
    }

    private void panelCanvas_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        OnSelection(e);
    }

    #region Selecting

    private Figure? selectedFigure = null;
    private Markers markers = new Markers();

    private void OnSelection(MouseEventArgs e)
    {
        var foundFigure = CheckHit(e.Location);
        if (foundFigure == null) return;
        if (selectedFigure == foundFigure)
        {
            selectedFigure = null;
            currentHeldMarkerIndex = -1;
        }
        else
            selectedFigure = foundFigure;

        markers = new Markers();
        panelCanvas.Invalidate();

    }

    private int currentHeldMarkerIndex = -1;

    private Size? oldSize;
    private void OnSelectionResizeStart(MouseEventArgs e)
    {
        if (selectedFigure == null) return;
        var markerIndex = markers.MarkersHitTest(e.Location);
        if (markerIndex == -1) return;
        currentHeldMarkerIndex = markerIndex;
        oldSize = selectedFigure?.Size;
        _oldLocation = selectedFigure?.Location;
    }

    private void OnSelectionResizeMove(MouseEventArgs e)
    {
        if (previousMousePosition == null || selectedFigure == null) return;

        var resizingDirectionX = ResizingHelper.GetResizingDirectionX(currentHeldMarkerIndex);
        var resizingDirectionY = ResizingHelper.GetResizingDirectionY(currentHeldMarkerIndex);
        var delta = new Point(e.Location.X - previousMousePosition.Value.X, e.Location.Y - previousMousePosition.Value.Y);



        if (resizingDirectionX == ResizingHelper.ResizingDirectionX.Left)
        {

            selectedFigure.ResizeFigure(new Size(
                    Math.Abs(selectedFigure.Size.Width - delta.X), selectedFigure.Size.Height));
            selectedFigure.MoveFigure(delta.X, 0);

        }
        else if (resizingDirectionX == ResizingHelper.ResizingDirectionX.Right)
        {
            selectedFigure.ResizeFigure(new Size(selectedFigure.Size.Width + delta.X,
                        selectedFigure.Size.Height));
        }

        if (resizingDirectionY == ResizingHelper.ResizingDirectionY.Top)
        {
            selectedFigure.ResizeFigure(new Size(
                selectedFigure.Size.Width, Math.Abs(selectedFigure.Size.Height - delta.Y)));
            selectedFigure.MoveFigure(0, delta.Y);
        }
        else if (resizingDirectionY == ResizingHelper.ResizingDirectionY.Bottom)
        {
            selectedFigure.ResizeFigure(new Size(selectedFigure.Size.Width, selectedFigure.Size.Height + delta.Y));
        }

        panelCanvas.Invalidate();
    }

    private void OnSelectionResizeEnd(MouseEventArgs e)
    {
        if (oldSize == null || currentHeldMarkerIndex == -1 || selectedFigure == null) return;


        currentHeldMarkerIndex = -1;
        InitiateAction(new ResizeActionFigure(oldSize, selectedFigure.Size, _oldLocation, selectedFigure.Location, selectedFigure));
    }

    private static class ResizingHelper
    {
        public enum ResizingDirectionX
        {
            Left,
            Right,
            None
        }

        public enum ResizingDirectionY
        {
            Top,
            Bottom,
            None
        }


        public static ResizingDirectionX GetResizingDirectionX(int markerIndex)
        {


            if (markerIndex == 2 || markerIndex == 4 || markerIndex == 7)
                return ResizingDirectionX.Right;

            if (markerIndex == 0 || markerIndex == 3 || markerIndex == 5)
                return ResizingDirectionX.Left;
            return ResizingDirectionX.None;
        }

        public static ResizingDirectionY GetResizingDirectionY(int markerIndex)
        {
            if (markerIndex == -1) return ResizingDirectionY.None;
            if (markerIndex < 0 || markerIndex > 7) throw new ArgumentOutOfRangeException(nameof(markerIndex));



            if (markerIndex <= 2)
                return ResizingDirectionY.Top;

            if (markerIndex >= 5)
                return ResizingDirectionY.Bottom;
            return ResizingDirectionY.None;
        }
    }

    #endregion

    #region Holding


    private Figure? currentlyHeldFigure = null;

    private Point? _oldLocation = null;




    private void OnHoldStarted(MouseEventArgs e)
    {
        var hitFigure = CheckHit(e.Location);
        if (hitFigure == null) return;

        _oldLocation = hitFigure.Location;
        currentlyHeldFigure = hitFigure;

    }

    private void OnHoldEnded(MouseEventArgs e)
    {
        if (currentlyHeldFigure == null) return;
        InitiateAction(new MoveFigureAction(_oldLocation, currentlyHeldFigure.Location, currentlyHeldFigure));


        currentlyHeldFigure = null;

        _oldLocation = null;
    }


    private void OnHoldMoved(MouseEventArgs e)
    {
        if (currentlyHeldFigure == null || previousMousePosition == null) return;

        Point delta = new Point(e.Location.X - previousMousePosition.Value.X,
            e.Location.Y - previousMousePosition.Value.Y);

        previousMousePosition = e.Location;

        currentlyHeldFigure.MoveFigure(delta.X, delta.Y);
        panelCanvas.Invalidate();
    }


    #endregion

    #region Actions

    private Figure? savedFigure;

    private void CopyFigure()
    {
        if (selectedFigure != null)
            savedFigure = (Figure)selectedFigure.Clone();
    }

    private void CutFigure()
    {
        if (selectedFigure != null)
        {
            savedFigure = (Figure)selectedFigure.Clone();

            InitiateAction(new DeleteFigureAction(canvasInfo, selectedFigure));
        }
    }

    private void PasteFigure()
    {
        if (savedFigure != null)
        {
            InitiateAction(new CreateNewFigureAction(canvasInfo, (Figure)savedFigure.Clone()));
        }

    }


    #endregion

    #region Keys

    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
        if (keyData == (Keys.Control | Keys.Z))
        {
            RollbackAction();
            return true;
        }

        if (keyData == (Keys.Control | Keys.S))
        {
            SaveFile();
            return true;
        }

        if (keyData == (Keys.Control | Keys.X))
        {
            CutFigure();
            return true;
        }

        if (keyData == (Keys.Control | Keys.C))
        {
            CopyFigure();
            return true;
        }

        if (keyData == (Keys.Control | Keys.V))
        {
            PasteFigure();
            return true;
        }

        if (keyData == Keys.Delete)
        {
            if (selectedFigure != null)
                InitiateAction(new DeleteFigureAction(canvasInfo, selectedFigure));
            return true;
        }

        var movementResult = MovementKeys(keyData);
        if (movementResult != null)
        {
            if (movementResult.Value)
                panelCanvas.Invalidate();
            return true;
        }

        return base.ProcessCmdKey(ref msg, keyData);
    }



    protected bool? MovementKeys(Keys keydata)
    {
        if (selectedFigure == null) return null;
        var movementAmount = 5;
        if ((keydata & Keys.Shift) == Keys.Shift)
            movementAmount = 1;

        var keyCode = keydata & Keys.KeyCode;
        switch (keyCode)
        {
            case Keys.Left:
                selectedFigure.MoveFigure(-movementAmount, 0); break;
            case Keys.Right:
                selectedFigure.MoveFigure(movementAmount, 0); break;
            case Keys.Up:
                selectedFigure.MoveFigure(0, -movementAmount); break;
            case Keys.Down:
                selectedFigure.MoveFigure(0, movementAmount); break;
            default: return null;
        }

        return true;

    }
    #endregion

    private void colorPaletteControl1_ColorChanged(object sender, Color e)
    {
        if (selectedFigure != null)
        {
            InitiateAction(new ColorChangeAction(selectedFigure.FigureColor, e, selectedFigure));
        }

        panelCanvas.Invalidate();
    }

    private void trackBar1_Scroll(object sender, EventArgs e)
    {
        if (selectedFigure != null)
        {
            selectedFigure.FigureStroke.Width = trackBar1.Value;
        }

        panelCanvas.Invalidate();
    }

    private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
    {
        SaveFile();
    }

    private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
    {
        SaveFile(true);
    }

    private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
    {
        OpenFile();
    }

    private void toolStripButton2_Click(object sender, EventArgs e)
    {
        OpenFile();
    }

    private void toolStripButton3_Click(object sender, EventArgs e)
    {
        SaveFile();
    }

    private void toolStripButton4_Click(object sender, EventArgs e)
    {
        RollbackAction();
    }

    private void квадратПрямоугольникToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var figure = new Square(new Point(5, 5), new Size(20, 20));
        figure.FigureColor = colorPaletteControl1.SelectedColor;
        figure.FigureStroke.Width = trackBar1.Value;
        figure.FigureStroke.Color = Color.Black;
        InitiateAction(new CreateNewFigureAction(canvasInfo, figure));
    }

    private void прямоугольникСДыркойToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var figure = new SquareWithHole(new Point(5, 5), new Size(20, 20));
        figure.FigureColor = colorPaletteControl1.SelectedColor;
        figure.FigureStroke.Width = trackBar1.Value;
        figure.FigureStroke.Color = Color.Black;
        InitiateAction(new CreateNewFigureAction(canvasInfo, figure));
    }
}

public class CanvasInfo
{
    public List<Figure> ActiveFigures { get; private set; }= new List<Figure>();

    private readonly MessagePackSerializerOptions options = MessagePackSerializerOptions.Standard.WithResolver(
        CompositeResolver.Create(
            new IMessagePackFormatter[] { new ColorFormatter(),},
            new IFormatterResolver[]
             {
                NativeGuidResolver.Instance,
                NativeDecimalResolver.Instance,
                TypelessContractlessStandardResolver.Instance,
                StandardResolver.Instance
            }
        )
    );

    public byte[] SerializeToBytes()
    {
        return MessagePackSerializer.Serialize(ActiveFigures, options);
    }

    public void SerializeFromBytes(byte[] bytes)
    {
        try
        {

            ActiveFigures = MessagePackSerializer.Deserialize<List<Figure>>(bytes, options);
        }
        catch (SerializationException e)
        {
            MessageBox.Show(@"Failed to deserialize. " + e.Message);
        }
    }
}