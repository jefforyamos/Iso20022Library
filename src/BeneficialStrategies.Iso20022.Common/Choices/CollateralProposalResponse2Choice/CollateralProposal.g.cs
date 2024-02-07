﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CollateralProposal.  ISO2002 ID# _vslfMWTUEeSSTJlMfOKFsA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.CollateralProposalResponse2Choice;

/// <summary>
/// Provides the collateral proposal response for the variation margin and optionaly the segregated independent amount.
/// </summary>
public partial record CollateralProposal : CollateralProposalResponse2Choice_
     , IIsoXmlSerilizable<CollateralProposal>
{
    #nullable enable
    
    /// <summary>
    /// Provides the collateral proposal response for the variation margin.
    /// </summary>
    public required CollateralProposalResponseType2 VariationMargin { get; init; } 
    /// <summary>
    /// Provides the collateral proposal response for the segregated independent amount.
    /// </summary>
    public CollateralProposalResponseType2? SegregatedIndependentAmount { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "VartnMrgn", xmlNamespace );
        VariationMargin.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SegregatedIndependentAmount is CollateralProposalResponseType2 SegregatedIndependentAmountValue)
        {
            writer.WriteStartElement(null, "SgrtdIndpdntAmt", xmlNamespace );
            SegregatedIndependentAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new CollateralProposal Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
