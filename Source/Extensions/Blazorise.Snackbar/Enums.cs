﻿#region Using directives
#endregion

namespace Blazorise.Snackbar;

/// <summary>
/// Defines the snackbar location.
/// </summary>
public enum SnackbarLocation
{
    /// <summary>
    /// Default behavior.
    /// </summary>
    Default,

    /// <summary>
    /// Show the snackbar on the left side of the screen.
    /// </summary>
    Start,

    /// <summary>
    /// Show the snackbar on the right side of the screen.
    /// </summary>
    End,
}

/// <summary>
/// Defines the snackbar stack location.
/// </summary>
public enum SnackbarStackLocation
{
    /// <summary>
    /// Default behavior.
    /// </summary>
    Center,

    /// <summary>
    /// Show the snackbar stack on the left side of the screen.
    /// </summary>
    Start,

    /// <summary>
    /// Show the snackbar stack on the right side of the screen.
    /// </summary>
    End,
}

/// <summary>
/// Predefined set of contextual colors.
/// </summary>
public enum SnackbarColor
{
    /// <summary>
    /// No color will be applied to an element.
    /// </summary>
    Default,

    /// <summary>
    /// Primary color.
    /// </summary>
    Primary,

    /// <summary>
    /// Secondary color.
    /// </summary>
    Secondary,

    /// <summary>
    /// Success color.
    /// </summary>
    Success,

    /// <summary>
    /// Danger color.
    /// </summary>
    Danger,

    /// <summary>
    /// Warning color.
    /// </summary>
    Warning,

    /// <summary>
    /// Info color.
    /// </summary>
    Info,

    /// <summary>
    /// Light color.
    /// </summary>
    Light,

    /// <summary>
    /// Dark color.
    /// </summary>
    Dark,
}

/// <summary>
/// Specifies the reason that a snackbar was closed.
/// </summary>
public enum SnackbarCloseReason
{
    /// <summary>
    /// Snackbar is closed automatically by internal timer or by other unknown reason.
    /// </summary>
    None,

    /// <summary>
    /// Snackbar is closed by the user.
    /// </summary>
    UserClosed,
}