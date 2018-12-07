﻿#region Using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Blazorise.Bulma
{
    class BulmaClassProvider : IClassProvider
    {
        #region Text

        public virtual string Text( bool plaintext ) => plaintext ? "control input is-static" : "control input";

        public virtual string TextSize( Size size ) => Size( size );

        public virtual string TextColor( Color color ) => $"is-{Color( color )}";

        #endregion

        #region Memo

        public virtual string Memo() => "textarea";

        #endregion

        #region Select

        public virtual string Select() => "control select is-fullwidth";

        public virtual string SelectSize( Size size ) => $"{Size( size )}";

        #endregion

        #region Date

        public string Date() => "control input";

        public string DateSize( Size size ) => $"{Size( size )}";

        #endregion

        #region Check

        public string Check() => "control checkbox";

        public string CheckInline() => "inline";

        #endregion

        #region Radio

        public virtual string Radio() => "control radio";

        public virtual string RadioInline() => "inline";

        #endregion

        #region File

        public virtual string File() => "file-input";

        #endregion

        #region Label

        public string Label() => "label";

        public string LabelCheck() => "checkbox";

        public string LabelFile() => "file-label";

        #endregion

        #region Help

        public string Help() => "help";

        #endregion

        #region Fields

        public virtual string Fields() => "field";

        public virtual string FieldsBody() => "field-body";

        public virtual string FieldsColumn() => $"{Col()}";

        //public virtual string FieldsColumnSize( ColumnSize columnSize ) => $"is-{ColumnSize( columnSize )}";

        #endregion

        #region Field

        public virtual string Field() => "field";

        public virtual string FieldHorizontal() => "is-horizontal";

        public virtual string FieldColumn() => $"{Col()}";

        public virtual string FieldJustifyContent( JustifyContent justifyContent ) => JustifyContent( justifyContent );

        #endregion

        #region FieldLabel

        public virtual string FieldLabel() => "field-label";

        public virtual string FieldLabelHorizontal() => null;

        #endregion

        #region FieldHelp

        public virtual string FieldHelp() => "help";

        #endregion

        #region Control

        public virtual string ControlCheck() => "control";

        public virtual string ControlRadio() => "control";

        public virtual string ControlFile() => "file has-name";

        public virtual string ControlText() => "control";

        #endregion

        #region Addons

        public virtual string Addons() => "field has-addons";

        public virtual string Addon( AddonType addonType )
        {
            switch ( addonType )
            {
                case AddonType.Start:
                case AddonType.End:
                    return "control";
                default:
                    return "control is-expanded";
            }
        }

        public virtual string AddonLabel() => "button is-static";

        public virtual string AddonContainer() => "control";

        #endregion

        #region Inline

        public virtual string Inline() => "field is-horizontal";

        #endregion

        #region Button

        public virtual string Button() => "button";

        public virtual string ButtonColor( Color color ) => $"is-{Color( color )}";

        public virtual string ButtonOutline( Color color ) => $"is-outlined";

        public virtual string ButtonSize( Size size ) => $"{Size( size )}";

        public virtual string ButtonBlock() => $"is-fullwidth";

        public virtual string ButtonActive() => "is-active";

        #endregion

        #region Buttons

        //public virtual string Buttons() => "buttons has-addons";

        public virtual string ButtonsAddons() => "field has-addons";

        public virtual string ButtonsToolbar() => "field is-grouped";

        public virtual string ButtonsSize( Size size ) => $"{Size( size )}";

        public virtual string ButtonsVertical() => "buttons";

        #endregion

        #region CloseButton

        public virtual string CloseButton() => "delete";

        #endregion

        #region Dropdown

        public virtual string Dropdown() => "dropdown";

        public virtual string DropdownGroup() => "field has-addons";

        public virtual string DropdownShow() => Active();

        public virtual string DropdownRight() => "is-right";

        public virtual string DropdownItem() => "dropdown-item";

        public virtual string DropdownDivider() => "dropdown-divider";

        public virtual string DropdownMenu() => "dropdown-menu";

        public virtual string DropdownMenuBody() => "dropdown-content";

        public virtual string DropdownMenuShow() => null;

        public virtual string DropdownMenuRight() => null;

        public virtual string DropdownToggle() => "dropdown-trigger";

        public virtual string DropdownToggleSplit() => null;

        public virtual string DropdownDirection( Direction direction )
        {
            switch ( direction )
            {
                case Direction.Up:
                    return "is-up";
                case Direction.Right:
                    return "is-right";
                case Direction.Left:
                    return "is-left";
                case Direction.Down:
                case Direction.None:
                default:
                    return null;
            }
        }

        #endregion

        #region Tab

        public virtual string Tabs() => "tabs";

        public virtual string TabsCards() => null;

        public virtual string TabsPills() => "is-toggle";

        public virtual string TabsFullWidth() => "is-fullwidth";

        public virtual string TabsJustified() => "is-justified";

        public virtual string TabsVertical() => null;

        public virtual string TabItem() => null;

        public virtual string TabItemActive() => $"{Active()}";

        public virtual string TabLink() => null;

        public virtual string TabLinkActive() => null;

        public virtual string TabContent() => "tab-content";

        public virtual string TabPanel() => "tab-pane";

        public virtual string TabPanelActive() => $"{Active()}";

        //public virtual string Tab() => "tabs";

        //public virtual string TabPage() => null;

        //public virtual string TabPageActive() => $"{Active()}";

        #endregion

        #region Card

        public virtual string CardGroup() => "card-group";

        public virtual string Card() => "card";

        public virtual string CardWhiteText() => "has-text-white";

        public virtual string CardBackground( Background background ) => BackgroundColor( background );

        public virtual string CardActions() => "card-actions";

        public virtual string CardBody() => "card-content";

        public virtual string CardFooter() => "card-footer";

        public virtual string CardHeader() => "card-header";

        public virtual string CardImage() => "card-image";

        public virtual string CardTitle() => "card-header-title";

        public virtual string CardSubtitle() => "subtitle";

        public virtual string CardSubtitleSize( int size ) => $"is-{size}";

        public virtual string CardText() => "card-text";

        public virtual string CardLink() => null;

        #endregion

        #region ListGroup

        public virtual string ListGroup() => "list-group";

        public virtual string ListGroupFlush() => "list-group-flush";

        public virtual string ListGroupItem() => "list-group-item";

        public virtual string ListGroupItemActive() => Active();

        public virtual string ListGroupItemDisabled() => Disabled();

        #endregion

        #region Container

        public virtual string Container() => "container";

        public virtual string ContainerFluid() => "container-fluid";

        #endregion

        #region Panel

        public virtual string Panel() => null;

        #endregion

        #region Nav

        public virtual string Nav() => "nav";

        public virtual string NavItem() => "nav-item";

        public virtual string NavLink() => "nav-link";

        public virtual string NavTabs() => "nav-tabs";

        public virtual string NavCards() => "nav-cards";

        public virtual string NavPills() => "nav-pills";

        public virtual string NavFill( NavFillType fillType ) => fillType == NavFillType.Justified ? "nav-justified" : "nav-fill";

        public virtual string NavVertical() => "flex-column";

        #endregion

        #region Navbar

        public virtual string Bar() => "navbar";

        public virtual string BarShade( Theme theme ) => null;

        public virtual string BarBreakpoint( Breakpoint breakpoint ) => $"navbar-expand-{Breakpoint( breakpoint )}";

        public virtual string BarItem() => "navbar-item";

        public virtual string BarItemActive() => Active();

        public virtual string BarItemDisabled() => Disabled();

        public virtual string BarItemDropdown() => "has-dropdown";

        public virtual string BarItemDropdownShow() => Active();

        public virtual string BarLink() => "navbar-item";

        public virtual string BarLinkDisabled() => Disabled();

        //public virtual string BarCollapse() => "navbar-menu";

        public virtual string BarBrand() => "navbar-brand";

        public virtual string BarToggler() => "navbar-burger";

        public virtual string BarMenu() => "navbar-menu";

        public virtual string BarMenuShow() => Show();

        public virtual string BarStart() => "navbar-start";

        public virtual string BarEnd() => "navbar-end";

        //public virtual string BarHasDropdown() => "has-dropdown";

        public virtual string BarDropdown() => "navbar-dropdown";

        public virtual string BarDropdownShow() => Show();

        public virtual string BarDropdownToggler() => null;

        public virtual string BarDropdownItem() => "navbar-item";

        public virtual string BarTogglerIcon() => null;

        #endregion

        #region Collapse

        public virtual string Collapse() => "collapse";

        public virtual string CollapseShow() => Show();

        #endregion

        #region Row

        public virtual string Row() => "columns";

        #endregion

        #region Col

        public virtual string Col() => "column";

        public virtual string Col( ColumnWidth columnWidth, IEnumerable<(Breakpoint breakpoint, bool offset)> rules ) =>
              string.Join( " ", rules.Select( r => Col( columnWidth, r.breakpoint, r.offset ) ) );

        private string Col( ColumnWidth columnWidth, Breakpoint breakpoint, bool offset )
        {
            var offsetClass = offset ? "offset-" : null;

            if ( breakpoint != Blazorise.Breakpoint.None )
            {
                if ( columnWidth == Blazorise.ColumnWidth.Auto )
                    return $"{Col()} is-{Breakpoint( breakpoint )}";

                return $"{Col()} is-{Breakpoint( breakpoint )} is-{offsetClass}{ColumnWidth( columnWidth )}";
            }

            if ( columnWidth == Blazorise.ColumnWidth.Auto )
                return $"{Col()}";

            return $"{Col()} is-{offsetClass}{ColumnWidth( columnWidth )}";
        }

        #endregion

        #region Snackbar

        public virtual string Snackbar() => "notification";

        public virtual string SnackbarShow() => Show();

        public virtual string SnackbarMultiline() => null;

        public virtual string SnackbarBody() => null;

        public virtual string SnackbarAction() => "close";

        #endregion

        #region Alert

        public virtual string Alert() => "notification";

        public virtual string AlertColor( Color color ) => $"is-{Color( color )}";

        public virtual string AlertDismisable() => null;

        //public virtual string AlertShow( bool show ) => $"alert-dismissible {Fade()} {( show ? Show() : null )}";

        #endregion

        #region Modal

        public virtual string Modal() => "modal";

        public virtual string ModalFade() => null;

        public virtual string ModalShow() => $"{Active()}";

        public virtual string ModalBackdrop() => "modal-background";

        public virtual string ModalContent( bool isForm ) => isForm ? "modal-card" : "modal-content";

        public virtual string ModalContentCentered() => null;

        public virtual string ModalBody() => "modal-card-body";

        public virtual string ModalHeader() => "modal-card-head";

        public virtual string ModalFooter() => "modal-card-foot";

        public virtual string ModalHeaderTitle() => "modal-card-title";

        #endregion

        #region Pagination

        public virtual string Pagination() => "pagination";

        public virtual string PaginationSize( Size size ) => $"{Pagination()}-{Size( size )}";

        public virtual string PaginationItem() => "page-item";

        public virtual string PaginationLink() => "page-link";

        #endregion

        #region Progress

        public virtual string Progress() => "progress";

        public virtual string ProgressSize( Size size ) => $"is-{Size( size )}";

        public virtual string ProgressBar() => "progress";

        public virtual string ProgressBarStriped() => "progress-bar-striped";

        public virtual string ProgressBarAnimated() => "progress-bar-animated";

        public virtual string ProgressBarWidth( int width ) => $"w-{width}";

        #endregion

        #region Chart

        public virtual string Chart() => null;

        #endregion

        #region Colors

        public virtual string BackgroundColor( Background color ) => $"{Color( color )}";

        #endregion

        #region Title

        public virtual string Title() => "title";

        public virtual string TitleSize( int size ) => $"is-{size}";

        #endregion

        #region Table

        public virtual string Table() => "table";

        public virtual string TableFullWidth() => "is-fullwidth";

        public virtual string TableStriped() => "is-striped";

        public virtual string TableHoverable() => "is-hoverable";

        public virtual string TableBordered() => "is-bordered";

        public virtual string TableHeader() => null;

        public virtual string TableHeaderCell() => null;

        public virtual string TableBody() => null;

        public virtual string TableRow() => null;

        public virtual string TableRowHeader() => null;

        public virtual string TableRowCell() => null;

        #endregion

        #region Badge

        public virtual string Badge() => "badge";

        public virtual string BadgeColor( Color color )
        {
            switch ( color )
            {
                case Blazorise.Color.Primary:
                    return "is-badge-primary";
                case Blazorise.Color.Secondary:
                    return "is-badge-info";
                case Blazorise.Color.Success:
                    return "is-badge-success";
                case Blazorise.Color.Danger:
                    return "is-badge-danger";
                case Blazorise.Color.Warning:
                    return "is-badge-warning";
                case Blazorise.Color.Info:
                    return "is-badge-info";
                case Blazorise.Color.Link:
                    return "is-badge-link";
                default:
                    return null;
            }
        }

        public virtual string BadgePill() => null;

        #endregion

        #region Media

        public virtual string Media() => "media";

        public virtual string MediaLeft() => "media-left";

        public virtual string MediaRight() => "media-right";

        public virtual string MediaBody() => "media-content";

        #endregion

        #region SimpleText

        public virtual string SimpleTextColor( TextColor textColor ) => $"has-text-{TextColor( textColor )}";

        public virtual string SimpleTextAlignment( TextAlignment textAlignment ) => $"has-text-{TextAlignment( textAlignment )}";

        public virtual string SimpleTextTransform( TextTransform textTransform ) => $"is-{TextTransform( textTransform )}";

        public virtual string SimpleTextWeight( TextWeight textWeight ) => $"has-text-weight-{TextWeight( textWeight )}";

        public virtual string SimpleTextItalic() => "is-italic";

        #endregion

        #region Figure

        public virtual string Figure() => "image";

        #endregion

        #region States

        public virtual string Show() => "show";

        public virtual string Fade() => "fade";

        public virtual string Active() => "is-active";

        public virtual string Disabled() => "is-disabled";

        public virtual string Collapsed() => "collapsed";

        #endregion

        #region Layout

        // TODO: Bulma by default doesn't have spacing utilities. Try to fix this!
        public virtual string Spacing( Spacing spacing, SpacingSize spacingSize, Side side, Breakpoint breakpoint ) => $"{Spacing( spacing )}{Side( side )}-{SpacingSize( spacingSize )}";

        public virtual string Spacing( Spacing spacing, SpacingSize spacingSize, IEnumerable<(Side side, Breakpoint breakpoint)> rules ) => string.Join( " ", rules.Select( x => Spacing( spacing, spacingSize, x.side, x.breakpoint ) ) );

        #endregion

        #region Flex

        public virtual string FlexAlignment( Alignment alignment ) => $"justify-content-{Alignment( alignment )}";

        #endregion

        #region Enums

        public string Size( Size size )
        {
            switch ( size )
            {
                case Blazorise.Size.ExtraSmall:
                case Blazorise.Size.Small:
                    return "is-small";
                case Blazorise.Size.Medium:
                    return "is-medium";
                case Blazorise.Size.Large:
                case Blazorise.Size.ExtraLarge:
                    return "is-large";
                default:
                    return null;
            }
        }

        public string Breakpoint( Breakpoint breakpoint )
        {
            switch ( breakpoint )
            {
                case Blazorise.Breakpoint.Mobile:
                    return "mobile";
                case Blazorise.Breakpoint.Tablet:
                    return "tablet";
                case Blazorise.Breakpoint.Desktop:
                    return "desktop";
                case Blazorise.Breakpoint.Widescreen:
                    return "widescreen";
                case Blazorise.Breakpoint.FullHD:
                    return "fullhd";
                default:
                    return null;
            }
        }

        public string Color( Color color )
        {
            switch ( color )
            {
                case Blazorise.Color.Primary:
                    return "primary";
                case Blazorise.Color.Secondary:
                    return "info";
                case Blazorise.Color.Success:
                    return "success";
                case Blazorise.Color.Danger:
                    return "danger";
                case Blazorise.Color.Warning:
                    return "warning";
                case Blazorise.Color.Info:
                    return "info";
                case Blazorise.Color.Link:
                    return "link";
                default:
                    return null;
            }
        }

        public string Color( Background color )
        {
            switch ( color )
            {
                case Blazorise.Background.Primary:
                    return "has-background-primary";
                case Blazorise.Background.Secondary:
                    return "has-background-light";
                case Blazorise.Background.Success:
                    return "has-background-success";
                case Blazorise.Background.Danger:
                    return "has-background-danger";
                case Blazorise.Background.Warning:
                    return "has-background-warning";
                case Blazorise.Background.Info:
                    return "has-background-info";
                case Blazorise.Background.Light:
                    return "has-background-light";
                case Blazorise.Background.Dark:
                    return "has-background-dark";
                case Blazorise.Background.White:
                    return "has-background-white";
                case Blazorise.Background.Transparent:
                    return "transparent";
                default:
                    return null;
            }
        }

        public string TextColor( TextColor textColor )
        {
            switch ( textColor )
            {
                case Blazorise.TextColor.Primary:
                    return "primary";
                //case Blazorise.TextColor.Secondary:
                //    return "secondary";
                case Blazorise.TextColor.Success:
                    return "success";
                case Blazorise.TextColor.Danger:
                    return "danger";
                case Blazorise.TextColor.Warning:
                    return "warning";
                case Blazorise.TextColor.Info:
                    return "info";
                case Blazorise.TextColor.Light:
                    return "light";
                case Blazorise.TextColor.Dark:
                    return "dark";
                //case Blazorise.TextColor.Body:
                //    return "body";
                //case Blazorise.TextColor.Muted:
                //    return "muted";
                case Blazorise.TextColor.White:
                    return "white";
                //case Blazorise.TextColor.Black50:
                //    return "black-50";
                //case Blazorise.TextColor.White50:
                //    return "white-50";
                default:
                    return null;
            }
        }

        public string Theme( Theme theme )
        {
            switch ( theme )
            {
                case Blazorise.Theme.Light:
                    return "light";
                case Blazorise.Theme.Dark:
                    return "dark";
                default:
                    return null;
            }
        }

        public virtual string Float( Float @float )
        {
            switch ( @float )
            {
                case Blazorise.Float.Left:
                    return "is-pulled-left";
                case Blazorise.Float.Right:
                    return "is-pulled-right	";
                default:
                    return null;
            }
        }

        public virtual string Spacing( Spacing spacing )
        {
            switch ( spacing )
            {
                case Blazorise.Spacing.Margin:
                    return "m";
                case Blazorise.Spacing.Padding:
                    return "p";
                default:
                    return null;
            }
        }

        public virtual string Side( Side side )
        {
            switch ( side )
            {
                case Blazorise.Side.Top:
                    return "t";
                case Blazorise.Side.Bottom:
                    return "b";
                case Blazorise.Side.Left:
                    return "l";
                case Blazorise.Side.Right:
                    return "r";
                case Blazorise.Side.X:
                    return "x";
                case Blazorise.Side.Y:
                    return "y";
                default:
                    return null;
            }
        }

        public virtual string Alignment( Alignment alignment )
        {
            switch ( alignment )
            {
                case Blazorise.Alignment.Start:
                    return "start";
                case Blazorise.Alignment.Center:
                    return "center";
                case Blazorise.Alignment.End:
                    return "end";
                default:
                    return null;
            }
        }

        public virtual string TextAlignment( TextAlignment textAlignment )
        {
            switch ( textAlignment )
            {
                case Blazorise.TextAlignment.Left:
                    return "left";
                case Blazorise.TextAlignment.Center:
                    return "centered";
                case Blazorise.TextAlignment.Right:
                    return "right";
                case Blazorise.TextAlignment.Justified:
                    return "justified";
                default:
                    return null;
            }
        }

        public virtual string TextTransform( TextTransform textTransform )
        {
            switch ( textTransform )
            {
                case Blazorise.TextTransform.Lowercase:
                    return "lowercase";
                case Blazorise.TextTransform.Uppercase:
                    return "uppercase";
                case Blazorise.TextTransform.Capitalize:
                    return "capitalized";
                default:
                    return null;
            }
        }

        public virtual string TextWeight( TextWeight textWeight )
        {
            switch ( textWeight )
            {
                case Blazorise.TextWeight.Normal:
                    return "normal";
                case Blazorise.TextWeight.Bold:
                    return "bold";
                case Blazorise.TextWeight.Light:
                    return "light";
                default:
                    return null;
            }
        }

        public virtual string ColumnWidth( ColumnWidth columnWidth )
        {
            switch ( columnWidth )
            {
                case Blazorise.ColumnWidth.Is1:
                    return "1";
                case Blazorise.ColumnWidth.Is2:
                    return "2";
                case Blazorise.ColumnWidth.Is3:
                case Blazorise.ColumnWidth.Quarter:
                    return "3";
                case Blazorise.ColumnWidth.Is4:
                case Blazorise.ColumnWidth.Third:
                    return "4";
                case Blazorise.ColumnWidth.Is5:
                    return "5";
                case Blazorise.ColumnWidth.Is6:
                case Blazorise.ColumnWidth.Half:
                    return "6";
                case Blazorise.ColumnWidth.Is7:
                    return "7";
                case Blazorise.ColumnWidth.Is8:
                    return "8";
                case Blazorise.ColumnWidth.Is9:
                    return "9";
                case Blazorise.ColumnWidth.Is10:
                    return "10";
                case Blazorise.ColumnWidth.Is11:
                    return "11";
                case Blazorise.ColumnWidth.Is12:
                case Blazorise.ColumnWidth.Full:
                    return "12";
                default:
                    return null;
            }
        }

        public virtual string ModalSize( ModalSize modalSize )
        {
            switch ( modalSize )
            {
                case Blazorise.ModalSize.Small:
                    return "modal-sm";
                case Blazorise.ModalSize.Large:
                    return "modal-lg";
                case Blazorise.ModalSize.Default:
                default:
                    return null;
            }
        }

        public string SpacingSize( SpacingSize spacingSize )
        {
            switch ( spacingSize )
            {
                case Blazorise.SpacingSize.Is0:
                    return "0";
                case Blazorise.SpacingSize.Is1:
                    return "1";
                case Blazorise.SpacingSize.Is2:
                    return "2";
                case Blazorise.SpacingSize.Is3:
                    return "3";
                case Blazorise.SpacingSize.Is4:
                    return "4";
                case Blazorise.SpacingSize.Is5:
                    return "5";
                case Blazorise.SpacingSize.IsAuto:
                    return "auto";
                default:
                    return null;
            }
        }

        public string JustifyContent( JustifyContent justifyContent )
        {
            switch ( justifyContent )
            {
                case Blazorise.JustifyContent.Start:
                    return "justify-content-start";
                case Blazorise.JustifyContent.End:
                    return "justify-content-end";
                case Blazorise.JustifyContent.Center:
                    return "justify-content-center";
                case Blazorise.JustifyContent.Between:
                    return "justify-content-between";
                case Blazorise.JustifyContent.Around:
                    return "justify-content-around";
                default:
                    return null;
            }
        }

        #endregion

        public bool Custom { get; set; } = false;

        public string Provider => "Bulma";
    }
}
