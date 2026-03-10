namespace WinForm;

public class NumericUpDownPrecision : NumericUpDown
{
    public override void UpButton()
    {
        Value = Value * 10;
    }

    public override void DownButton()
    {
        Value = Value / 10;
    }
}