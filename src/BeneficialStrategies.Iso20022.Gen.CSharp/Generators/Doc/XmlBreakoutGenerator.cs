global using Max70Text = System.String;
using System.Text;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Repository;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Gen.CSharp;

public class XmlBreakoutElement : IsoRepoElement
{
    public XmlBreakoutElement(XDocument loadedXmlDocument, DirectoryInfo targetDirectory)
        : base(loadedXmlDocument.Root ?? throw new ArgumentException("No root document found", nameof(loadedXmlDocument)))
    {
        var root = loadedXmlDocument?.Root
            ?? throw new ArgumentException("No root document found", nameof(loadedXmlDocument));
        Element = root;
        Level = 0;
        FileName = "README.md";
        HomeDirectory = targetDirectory;
        Children = Element.Elements()
            .Select(e => new XmlBreakoutElement(e, this))
            .ToArray();
    }

    private XmlBreakoutElement(XElement xElement,XmlBreakoutElement parent) : base(xElement)
    {
        Element = xElement;
        Parent = parent;
        Level = parent.Level + 1;
        HomeDirectory = parent.HomeDirectory;
        Children = xElement.Elements()
            .Select(e => new XmlBreakoutElement(e, this))
            .ToArray();
        FileName = $"{this.Id}.md";
    }

    XmlBreakoutElement? Parent { get; }

    public XElement Element { get; }

    public DirectoryInfo HomeDirectory { get; }

    public int Level { get; }

    public XmlBreakoutElement[] Children { get; }

    public virtual bool ShouldCreateChildren => Level < 3;

    public virtual bool ShouldPutXmlInDoc => Level > 2;

    public string FileName { get; }

    public void Generate()
    {
        if (!HomeDirectory.Exists) HomeDirectory.Create();

        // Write README.md with lookups
        var readmeFullPath = Path.Combine(HomeDirectory.FullName, FileName);
        using var outputFileStream = new FileStream(readmeFullPath, FileMode.Create);
        using var writer = new StreamWriter(outputFileStream, Encoding.UTF8);

        WriteReadmeContent(writer);

        writer.Flush();
        writer.Close();

        if ( ShouldCreateChildren )
        {
            foreach (var child in Children)
            {
                child.Generate();
            }
        }
    }

    protected virtual void WriteReadmeContent(TextWriter textWriter)
    {
        textWriter.WriteLine($"# {this.Name ?? "Repository"}");
        textWriter.WriteLine();

        textWriter.WriteLine("## Attributes");
        textWriter.WriteLine("| Attribute  | Value     |");
        textWriter.WriteLine("|------------|-----------|");
        textWriter.WriteLine();
        foreach (var att in Element.Attributes())
        {
            var attValue = att?.Value ?? string.Empty;
            // if (attValue.Length > 100) attValue = "(too long to display)";
            textWriter.WriteLine($@"|{att?.Name ?? "_"}|{attValue}|");
        }

        textWriter.WriteLine("## Child Elements");
        textWriter.WriteLine("| Element    | Name      | Description |Link|");
        textWriter.WriteLine("|------------|-----------|-------------|----|");
        textWriter.WriteLine();
        foreach (var child in Children)
        {
            textWriter.WriteLine($@"|{child.Element.Name}|{child.Name}|{child.Definition.FixStringForEnclusionInQuotedAttribute()}|[==>]({child.Id}.md)|");
        }

        
        if (ShouldPutXmlInDoc) WriteXmlContent(textWriter);

        if( this.Parent != null)
        { 
            textWriter.WriteLine($@"Return to [{this.Parent.Name}]({this.Parent.FileName})");
        }
    }

    protected virtual void WriteXmlContent(TextWriter textWriter)
    {
        textWriter.WriteLine("## Xml Content");
        textWriter.WriteLine("```XML");
        var sb = new StringBuilder();
        using (var xmlWriter = XmlWriter.Create(sb, new XmlWriterSettings { Indent = true, OmitXmlDeclaration = true } ))
        {
            Element.WriteTo(xmlWriter);
            xmlWriter.Flush();
            textWriter.WriteLine(sb.ToString());
        }
        textWriter.WriteLine("```");
    }
}


public class XmlBreakoutGenerator : IGenerate
{
    public XmlBreakoutGenerator()
    {
    }

    public void Generate(IsoRepository repo, DirectoryInfo projectDirectoryRoot)
    {
        //var root = repo?.LoadedXDocument?.Root;
        // if (root == null) throw new InvalidOperationException("Null root element in document");
        var solutionRoot = projectDirectoryRoot.Parent;
        if (solutionRoot == null || !solutionRoot.Exists) throw new InvalidOperationException("Can't locate SLN root");
        var docDirectory = new DirectoryInfo(Path.Combine(solutionRoot.FullName, "Doc"));
        if (docDirectory.Exists) docDirectory.Create();
        var rootGenerator = new XmlBreakoutElement(repo.LoadedXDocument, docDirectory);
        rootGenerator.Generate();
    }
}

