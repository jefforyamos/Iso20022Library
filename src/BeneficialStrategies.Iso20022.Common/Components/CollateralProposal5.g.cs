﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CollateralProposal5.  ISO2002 ID# _zeoQX4FvEeWtPe6Crjmeug.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about the proposal for the variation margin and optionaly the segregated independent amount.
/// </summary>
public partial record CollateralProposal5
     : IIsoXmlSerilizable<CollateralProposal5>
{
    #nullable enable
    
    /// <summary>
    /// Provides details about the proposal for the variation margin.
    /// </summary>
    public required CollateralMovement7 VariationMargin { get; init; } 
    /// <summary>
    /// Provides details about the proposal for the segregated independent amount.
    /// </summary>
    public CollateralMovement7? SegregatedIndependentAmount { get; init; } 
    
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
        if (SegregatedIndependentAmount is CollateralMovement7 SegregatedIndependentAmountValue)
        {
            writer.WriteStartElement(null, "SgrtdIndpdntAmt", xmlNamespace );
            SegregatedIndependentAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CollateralProposal5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
