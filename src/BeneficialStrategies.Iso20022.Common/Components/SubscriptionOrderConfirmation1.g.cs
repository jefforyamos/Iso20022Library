﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SubscriptionOrderConfirmation1.  ISO2002 ID# _RNqrENp-Ed-ak6NoX_4Aeg_-910205350.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Order confirmation details.
/// </summary>
public partial record SubscriptionOrderConfirmation1
     : IIsoXmlSerilizable<SubscriptionOrderConfirmation1>
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether a confirmation amendment message will follow the confirmation cancellation instruction or not.
    /// </summary>
    public required IsoYesNoIndicator AmendmentIndicator { get; init; } 
    /// <summary>
    /// General information related to the execution of investment fund order.
    /// </summary>
    public required SubscriptionMultipleExecution3 MultipleExecutionDetails { get; init; } 
    /// <summary>
    /// Information about parties related to the transaction.
    /// </summary>
    public ValueList<Intermediary9> RelatedPartyDetails { get; init; } = [];
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public Extension1? Extension { get; init; } 
    
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
        writer.WriteStartElement(null, "AmdmntInd", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(AmendmentIndicator)); // data type YesNoIndicator System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "MltplExctnDtls", xmlNamespace );
        MultipleExecutionDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "RltdPtyDtls", xmlNamespace );
        RelatedPartyDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Extension is Extension1 ExtensionValue)
        {
            writer.WriteStartElement(null, "Xtnsn", xmlNamespace );
            ExtensionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SubscriptionOrderConfirmation1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
