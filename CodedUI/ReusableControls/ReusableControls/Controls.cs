using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace ReusableControls
{
    class Controls
    {
        private HtmlImage calculatorsAndToolsImg;
        public HtmlImage CalculatorsAndToolsImg{
            get{
                calculatorsAndToolsImg.SearchProperties.Add(HtmlImage.PropertyNames.TagName, "IMG");
                calculatorsAndToolsImg.SearchProperties.Add(HtmlImage.PropertyNames.Alt, "Calculators and Tools");
                return CalculatorsAndToolsImg;

        }
        }
        
            private HtmlHyperlink squareRootLink;
            public HtmlHyperlink SquareRootLink{

                get{

                calculatorsAndToolsImg.SearchProperties.Add(HtmlHyperlink.PropertyNames.TagName, "A");
                calculatorsAndToolsImg.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, "Squire Root");
                return squareRootLink;

                }
            }

            private HtmlEdit numberEdit;
            public HtmlEdit NumberEdit{

                get{

                numberEdit.SearchProperties.Add(HtmlEdit.PropertyNames.TagName, "INPUT");
                numberEdit.SearchProperties.Add(HtmlEdit.PropertyNames.Type, "SINGLELINE");
                numberEdit.SearchProperties.Add(HtmlEdit.PropertyNames.Name, "num");
                
                return numberEdit;

                }
            }

            private HtmlButton calculateBtn;
            public HtmlButton CalculateBtn{

                get{
                calculateBtn.SearchProperties.Add(HtmlButton.PropertyNames.TagName, "INPUT");
                calculateBtn.SearchProperties.Add(HtmlButton.PropertyNames.Name, "Button");
                calculateBtn.SearchProperties.Add(HtmlButton.PropertyNames.Type, "Button");
                calculateBtn.SearchProperties.Add(HtmlButton.PropertyNames.DisplayText, " Calculate ");
                
                return calculateBtn;

                }
            }



            private HtmlEdit answerEdit;
            public HtmlEdit AnswerEdit{

                get{

                answerEdit.SearchProperties.Add(HtmlEdit.PropertyNames.TagName, "INPUT");
                answerEdit.SearchProperties.Add(HtmlEdit.PropertyNames.Type, "SINGLELINE");
                answerEdit.SearchProperties.Add(HtmlEdit.PropertyNames.Name, "answer");
                
                return answerEdit;

                }
            }

    }


    }
}
