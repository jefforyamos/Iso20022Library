﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Sale1.  ISO2002 ID# _MIdVI_JuEeiJn9rM2Znz2w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of good and services included in the sale.
/// </summary>
public partial record Sale1
     : IIsoXmlSerilizable<Sale1>
{
    #nullable enable
    
    /// <summary>
    /// Sale summary information.
    /// </summary>
    public SaleSummary1? Summary { get; init; } 
    /// <summary>
    /// Sale line item information.
    /// </summary>
    public SaleItem2? LineItem { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (Summary is SaleSummary1 SummaryValue)
        {
            writer.WriteStartElement(null, "Summry", xmlNamespace );
            SummaryValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LineItem is SaleItem2 LineItemValue)
        {
            writer.WriteStartElement(null, "LineItm", xmlNamespace );
            LineItemValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Sale1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
