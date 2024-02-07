﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CollateralProposalDetails.  ISO2002 ID# _P0F1UV9-EeSMgPeFpRHeJw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.CollateralProposal3Choice;

/// <summary>
/// Provides details about the proposal for the variation margin and optionaly the segregated independent amount.
/// </summary>
public partial record CollateralProposalDetails : CollateralProposal3Choice_
     , IIsoXmlSerilizable<CollateralProposalDetails>
{
    #nullable enable
    
    /// <summary>
    /// Provides details about the proposal for the variation margin.
    /// </summary>
    public required CollateralMovement5 VariationMargin { get; init; } 
    /// <summary>
    /// Provides details about the proposal for the segregated independent amount.
    /// </summary>
    public CollateralMovement5? SegregatedIndependentAmount { get; init; } 
    
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
        if (SegregatedIndependentAmount is CollateralMovement5 SegregatedIndependentAmountValue)
        {
            writer.WriteStartElement(null, "SgrtdIndpdntAmt", xmlNamespace );
            SegregatedIndependentAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new CollateralProposalDetails Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
