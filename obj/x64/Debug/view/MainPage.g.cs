#pragma checksum "C:\Users\rocha\source\repos\Pokedex--Grupo3\PokeDex\view\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DC88781522895D75659D1CB919EE37D2788D61089E21A7A39FC2EEB101558B6C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PokeDex.view
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // view\MainPage.xaml line 1
                {
                    this.PageMainPage = (global::Windows.UI.Xaml.Controls.Page)(target);
                }
                break;
            case 2: // view\MainPage.xaml line 13
                {
                    this.viewModels = (global::PokeDex.viewmodels.MainPageViewModels)(target);
                }
                break;
            case 3: // view\MainPage.xaml line 99
                {
                    this.gridRowTwo = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4: // view\MainPage.xaml line 106
                {
                    this.StackPane_Pri = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 5: // view\MainPage.xaml line 186
                {
                    this.gridRowTwoColumnTwo = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 6: // view\MainPage.xaml line 199
                {
                    this.GridViewPokemon = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            case 7: // view\MainPage.xaml line 314
                {
                    this.Loading = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 8: // view\MainPage.xaml line 207
                {
                    this.StyledGrid = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            case 10: // view\MainPage.xaml line 228
                {
                    global::Windows.UI.Xaml.Controls.Button element10 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element10).Click += this.ButtonPageNavigation;
                }
                break;
            case 16: // view\MainPage.xaml line 114
                {
                    this.StackPaneMenu = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 17: // view\MainPage.xaml line 157
                {
                    this.ButaoCadastro = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.ButaoCadastro).Click += this.ButaoCadastro_Click;
                }
                break;
            case 18: // view\MainPage.xaml line 129
                {
                    this.ButaoDB = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 19: // view\MainPage.xaml line 71
                {
                    this.BuscaPokemon = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 20: // view\MainPage.xaml line 78
                {
                    this.ButaoBuscaPokemon = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 21: // view\MainPage.xaml line 87
                {
                    this.ImageLupa = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

