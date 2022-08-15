namespace MagicNumber
{
    public class DisplayPage
    {
        private string _agentStr;

        public DisplayPage(string agentStr)
        {
            _agentStr = agentStr;
        }

        private string BrowserVersionMode
        {
            get
            {
                string agentStr = _agentStr.ToLower();
                string mode;
                if (agentStr.Contains("trident/6.0"))
                {
                    if (agentStr.Contains("msie 7.0"))
                    {
                        mode = "IE10 Compatibility View";
                    }
                    else
                    {
                        mode = "IE10";
                    }
                }
                else if (agentStr.Contains("trident/5.0"))
                {

                    if (agentStr.Contains("msie 7.0"))
                    {
                        mode = "IE9 Compatibility View";
                    }
                    else
                    {
                        mode = "IE9";
                    }
                }
                else if (agentStr.Contains("trident/4.0"))
                {
                    if (agentStr.Contains("msie 7.0"))
                    {
                        mode = "IE8 Compatibility View";
                    }
                    else
                    {
                        mode = "IE8";
                    }
                }
                else if (agentStr.Contains("applewebkit"))
                {
                    if (agentStr.Contains("version/4"))
                    {
                        mode = "Safari 4";
                    }
                    else
                    {
                        mode = "Safari";
                    }
                }
                else
                {
                    mode = "browsers";
                }
                return mode;
            }
        }

    }
}