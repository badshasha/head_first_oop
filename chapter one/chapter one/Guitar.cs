namespace chapter_one
{
    public class GuitartSpec
    {
        
        private Builder _builder;
        private Type _type;
        private string _backwood;
        private string _topwood;

        public GuitartSpec(Builder builder, Type type, string backwood, string topwood)
        {
            _builder = builder;
            _type = type;
            _backwood = backwood;
            _topwood = topwood;
        }
        
        public Type GetType()
        {
            return this._type;
        }

        public string GetBackWood()
        {
            return _backwood;
        }

        public Builder GetBuilder()
        {
            return this._builder;
        }
        
        
        
    }

    public class Guitar
    {
        private string _serialNumber;
        private GuitartSpec _gSpec;

        private double _price;

        public Guitar(string serialNumber, Builder builder, Type type, string backwood, string topwood, double price)
        {
            this._serialNumber = serialNumber;
            this._gSpec = new GuitartSpec(builder, type, backwood, topwood);
            this._price = price;
        }

        public string GetSerialNumber()
        {
            return this._serialNumber;
        }

        public GuitartSpec Gspec()
        {
            return _gSpec;
        }




    }
}