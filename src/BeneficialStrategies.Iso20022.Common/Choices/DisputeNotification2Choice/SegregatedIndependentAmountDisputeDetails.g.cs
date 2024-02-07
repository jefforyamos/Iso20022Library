﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SegregatedIndependentAmountDisputeDetails.  ISO2002 ID# _KkjLoytOEeyOa655cLd-DQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.DisputeNotification2Choice;

/// <summary>
/// Provides the dispute notification details for the segregated independent amount only.
/// </summary>
public partial record SegregatedIndependentAmountDisputeDetails : DisputeNotification2Choice_
     , IIsoXmlSerilizable<SegregatedIndependentAmountDisputeDetails>
{
    #nullable enable
    
    /// <summary>
    /// Details of the disputed instruction.
    /// </summary>
    public required Dispute1 DisputeDetails { get; init; } 
    /// <summary>
    /// Specifies the type of dispute that is to be resolved regarding the disputed collateral amount.
    /// </summary>
    public DisputeResolutionType1Choice_? DisputeResolutionType1Choice { get; init; } 
    
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
        writer.WriteStartElement(null, "DsptDtls", xmlNamespace );
        DisputeDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (DisputeResolutionType1Choice is DisputeResolutionType1Choice_ DisputeResolutionType1ChoiceValue)
        {
            writer.WriteStartElement(null, "DsptRsltnTp1Chc", xmlNamespace );
            DisputeResolutionType1ChoiceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new SegregatedIndependentAmountDisputeDetails Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
