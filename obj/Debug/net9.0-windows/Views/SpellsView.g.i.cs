// Updated by XamlIntelliSenseFileGenerator 30/11/2024 23:56:49
#pragma checksum "..\..\..\..\Views\SpellsView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69346F883B4704E06F49407CCF35D4F62255E7AA"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace POkemonLikeCsharpB2.Views
{


    /// <summary>
    /// SpellsView
    /// </summary>
    public partial class SpellsView : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 14 "..\..\..\..\Views\SpellsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox MonsterFilterComboBox;

#line default
#line hidden


#line 20 "..\..\..\..\Views\SpellsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView SpellsListView;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/POkemonLikeCsharpB2;V1.0.0.0;component/views/spellsview.xaml", System.UriKind.Relative);

#line 1 "..\..\..\..\Views\SpellsView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.MonsterFilterComboBox = ((System.Windows.Controls.ComboBox)(target));

#line 14 "..\..\..\..\Views\SpellsView.xaml"
                    this.MonsterFilterComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.MonsterFilterComboBox_SelectionChanged);

#line default
#line hidden
                    return;
                case 2:
                    this.SpellsListView = ((System.Windows.Controls.ListView)(target));
                    return;
            }
            this._contentLoaded = true;
        }
    }
}
