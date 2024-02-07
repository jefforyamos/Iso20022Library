﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Margin1.  ISO2002 ID# _UnOn1dp-Ed-ak6NoX_4Aeg_-1003583230.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the elements used to calculate the collateral margin call for the variation margin and optionally the segregated independent amount.
/// </summary>
public partial record Margin1
     : IIsoXmlSerilizable<Margin1>
{
    #nullable enable
    
    /// <summary>
    /// Elements used to calculate the collateral margin call for the variation margin.
    /// </summary>
    public required VariationMargin1 VariationMargin { get; init; } 
    /// <summary>
    /// Elements used to calculate the collateral margin call for the segregated independent amount.
    /// </summary>
    public SegregatedIndependentAmountMargin1? SegregatedIndependentAmountMargin { get; init; } 
    
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
        writer.WriteStartElement(null, "VartnMrgn", xmlNamespace );
        VariationMargin.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SegregatedIndependentAmountMargin is SegregatedIndependentAmountMargin1 SegregatedIndependentAmountMarginValue)
        {
            writer.WriteStartElement(null, "SgrtdIndpdntAmtMrgn", xmlNamespace );
            SegregatedIndependentAmountMarginValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Margin1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
