using DotVVM.VS2015Extension.DothtmlEditorExtensions.Intellisense.Base;
using DotVVM.VS2015Extension.DothtmlEditorExtensions.Intellisense.Dothtml.Completions;
using Microsoft.VisualStudio.Language.Intellisense;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using DotVVM.Framework.Compilation.Parser;

namespace DotVVM.VS2015Extension.DothtmlEditorExtensions.Intellisense.Dothtml.CompletionProviders
{
    [Export(typeof(IDothtmlCompletionProvider))]
    public class MainDirectiveNameCompletionProvider : DirectiveNameHtmlCompletionProviderBase
    {
        public override IEnumerable<SimpleDothtmlCompletion> GetItems(DothtmlCompletionContext context)
        {
            var directives = new[] { ParserConstants.BaseTypeDirective, ParserConstants.MasterPageDirective, ParserConstants.ViewModelDirectiveName };

            var glyph = context.GlyphService.GetGlyph(StandardGlyphGroup.GlyphKeyword, StandardGlyphItem.GlyphItemPublic);
            return directives.Select(d => new SimpleDothtmlCompletion(d, d + " ", glyph));
        }
    }
}