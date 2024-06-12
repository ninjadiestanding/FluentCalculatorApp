namespace FluentCalculatorApp
{
    public class FluentCalculator
    {
        public FluentValue zero => new FluentValue(0);
        public FluentValue one => new FluentValue(1);
        public FluentValue two => new FluentValue(2);
        public FluentValue three => new FluentValue(3);
        public FluentValue four => new FluentValue(4);
        public FluentValue five => new FluentValue(5);
        public FluentValue six => new FluentValue(6);
        public FluentValue seven => new FluentValue(7);
        public FluentValue eight => new FluentValue(8);
        public FluentValue nine => new FluentValue(9);
        public FluentValue ten => new FluentValue(10);
    }

    public class FluentValue
    {
        public int? Value;

        public FluentValue(int? value)
        {
            Value = value;
        }

        public FluentOperation plus => new FluentOperation(Operation.Plus, value: Value);
        public FluentOperation minus => new FluentOperation(Operation.Minus, value: Value);
        public FluentOperation times => new FluentOperation(Operation.Times, value: Value);
        public FluentOperation dividedBy => new FluentOperation(Operation.DividedBy, value: Value);
    }

    public class FluentOperation
    {
        private Operation Operation;
        private int? Value;

        public FluentOperation(Operation operation, int? value = null)
        {
            Operation = operation;
            Value = value;
        }

        public FluentValue zero
        {
            get
            {
                if (Value != null)
                {
                    switch (Operation)
                    {
                        case Operation.Plus:
                            return new FluentValue(Value + 0);
                        case Operation.Minus:
                            return new FluentValue(Value - 0);
                        case Operation.Times:
                            return new FluentValue(Value * 0);
                        case Operation.DividedBy:
                            return null;
                        default:
                            return null;
                    }
                }
                else
                {
                    return null;
                }
            }
        }

        public FluentValue one
        {
            get
            {
                if (Value != null)
                {
                    switch (Operation)
                    {
                        case Operation.Plus:
                            return new FluentValue(Value + 1);
                        case Operation.Minus:
                            return new FluentValue(Value - 1);
                        case Operation.Times:
                            return new FluentValue(Value * 1);
                        case Operation.DividedBy:
                            return new FluentValue(Value / 1);
                        default:
                            return null;
                    }
                }
                else
                {
                    return null;
                }
            }
        }

        public FluentValue two
        {
            get
            {
                if (Value != null)
                {
                    switch (Operation)
                    {
                        case Operation.Plus:
                            return new FluentValue(Value + 2);
                        case Operation.Minus:
                            return new FluentValue(Value - 2);
                        case Operation.Times:
                            return new FluentValue(Value * 2);
                        case Operation.DividedBy:
                            return new FluentValue(Value / 2);
                        default:
                            return null;
                    }
                }
                else
                {
                    return null;
                }
            }
        }

        public FluentValue three
        {
            get
            {
                if (Value != null)
                {
                    switch (Operation)
                    {
                        case Operation.Plus:
                            return new FluentValue(Value + 3);
                        case Operation.Minus:
                            return new FluentValue(Value - 3);
                        case Operation.Times:
                            return new FluentValue(Value * 3);
                        case Operation.DividedBy:
                            return new FluentValue(Value / 3);
                        default:
                            return null;
                    }
                }
                else
                {
                    return null;
                }
            }
        }

        public FluentValue four
        {
            get
            {
                if (Value != null)
                {
                    switch (Operation)
                    {
                        case Operation.Plus:
                            return new FluentValue(Value + 4);
                        case Operation.Minus:
                            return new FluentValue(Value - 4);
                        case Operation.Times:
                            return new FluentValue(Value * 4);
                        case Operation.DividedBy:
                            return new FluentValue(Value / 4);
                        default:
                            return null;
                    }
                }
                else
                {
                    return null;
                }
            }
        }

        public FluentValue five
        {
            get
            {
                if (Value != null)
                {
                    switch (Operation)
                    {
                        case Operation.Plus:
                            return new FluentValue(Value + 5);
                        case Operation.Minus:
                            return new FluentValue(Value - 5);
                        case Operation.Times:
                            return new FluentValue(Value * 5);
                        case Operation.DividedBy:
                            return new FluentValue(Value / 5);
                        default:
                            return null;
                    }
                }
                else
                {
                    return null;
                }
            }
        }

        public FluentValue six
        {
            get
            {
                if (Value != null)
                {
                    switch (Operation)
                    {
                        case Operation.Plus:
                            return new FluentValue(Value + 6);
                        case Operation.Minus:
                            return new FluentValue(Value - 6);
                        case Operation.Times:
                            return new FluentValue(Value * 6);
                        case Operation.DividedBy:
                            return new FluentValue(Value / 6);
                        default:
                            return null;
                    }
                }
                else
                {
                    return null;
                }
            }
        }

        public FluentValue seven
        {
            get
            {
                if (Value != null)
                {
                    switch (Operation)
                    {
                        case Operation.Plus:
                            return new FluentValue(Value + 7);
                        case Operation.Minus:
                            return new FluentValue(Value - 7);
                        case Operation.Times:
                            return new FluentValue(Value * 7);
                        case Operation.DividedBy:
                            return new FluentValue(Value / 7);
                        default:
                            return null;
                    }
                }
                else
                {
                    return null;
                }
            }
        }

        public FluentValue eight
        {
            get
            {
                if (Value != null)
                {
                    switch (Operation)
                    {
                        case Operation.Plus:
                            return new FluentValue(Value + 8);
                        case Operation.Minus:
                            return new FluentValue(Value - 8);
                        case Operation.Times:
                            return new FluentValue(Value * 8);
                        case Operation.DividedBy:
                            return new FluentValue(Value / 8);
                        default:
                            return null;
                    }
                }
                else
                {
                    return null;
                }
            }
        }

        public FluentValue nine
        {
            get
            {
                if (Value != null)
                {
                    switch (Operation)
                    {
                        case Operation.Plus:
                            return new FluentValue(Value + 9);
                        case Operation.Minus:
                            return new FluentValue(Value - 9);
                        case Operation.Times:
                            return new FluentValue(Value * 9);
                        case Operation.DividedBy:
                            return new FluentValue(Value / 9);
                        default:
                            return null;
                    }
                }
                else
                {
                    return null;
                }
            }
        }

        public FluentValue ten
        {
            get
            {
                if (Value != null)
                {
                    switch (Operation)
                    {
                        case Operation.Plus:
                            return new FluentValue(Value + 10);
                        case Operation.Minus:
                            return new FluentValue(Value - 10);
                        case Operation.Times:
                            return new FluentValue(Value * 10);
                        case Operation.DividedBy:
                            return new FluentValue(Value / 10);
                        default:
                            return null;
                    }
                }
                else
                {
                    return null;
                }
            }
        }
    }

    public enum Operation
    {
        Plus = 0,
        Minus = 1,
        Times = 2,
        DividedBy = 3
    }
}
