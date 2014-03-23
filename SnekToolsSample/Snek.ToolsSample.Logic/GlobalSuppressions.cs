// --------------------------------------------------------------------------------------------------------------------
// <copyright company="software architects gmbh" file="GlobalSuppressions.cs">
//   (c) software architects gmbh
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Microsoft.Design", "CA2210:AssembliesShouldHaveValidStrongNames", Justification = "We work without strong naming")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Snek", Justification = "Reviewed, is OK")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Snek", Scope = "namespace", Target = "Snek.ToolsSample.Logic", Justification = "Reviewed, is OK")]
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Justification = "Just a sample", Scope = "namespace", Target = "Snek.ToolsSample.Logic")]
