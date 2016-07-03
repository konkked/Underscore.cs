namespace Underscore.Action
{
    public partial class SynchComponent : ISynchComponent
    {
        private readonly Function.ISynchComponent _fnSynch;
        private readonly IConvertComponent _actionConvert;
        private readonly Function.IConvertComponent _funcConvert;

	    public SynchComponent()
	    {
		    _fnSynch = new Function.SynchComponent();
			_actionConvert = new ConvertComponent();
			_funcConvert = new Function.ConvertComponent();
	    }

        public SynchComponent(Function.ISynchComponent fnSynch, IConvertComponent actionConvert, Function.IConvertComponent funcConvert)
        {
            _fnSynch = fnSynch;
            _actionConvert = actionConvert;
            _funcConvert = funcConvert;
        }
    }
}
