namespace FluentCalculatorApp
{
    public class SomeBool
    {
        public bool value { get; set; }

        public SomeBool(bool value)
        {
            this.value = value;
        }

        public static bool operator ==(SomeBool someBool, bool target)
        {
            bool result = someBool.value == target;
            someBool.value = !someBool.value;
            return result;
        }

        public static bool operator !=(SomeBool someBool, bool target)
        {
            return !(someBool == target);
        }
    }
}
