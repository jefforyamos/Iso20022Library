﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for TransferInDetails.  ISO2002 ID# _OFsU3Bg2EeK-_89we2b-bA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.Cancellation2Choice;

/// <summary>
/// Details of the transfer in request to cancel.
/// </summary>
public partial record TransferInDetails : Cancellation2Choice_
     , IIsoXmlSerilizable<TransferInDetails>
{
    #nullable enable
    
    /// <summary>
    /// General information related to the transfer of a financial instrument.
    /// </summary>
    public Transfer22? TransferDetails { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is __vBr5RgiEeK-_89we2b-bA
    /// <summary>
    /// Information related to the account into which the financial instrument is to be received.
    /// </summary>
    public required InvestmentAccount22 AccountDetails { get; init; } 
    /// <summary>
    /// Information related to the delivering side of the transfer.
    /// </summary>
    public DeliverInformation9? SettlementDetails { get; init; } 
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
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        // Not sure how to serialize TransferDetails, multiplicity Unknown
        writer.WriteStartElement(null, "AcctDtls", xmlNamespace );
        AccountDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SettlementDetails is DeliverInformation9 SettlementDetailsValue)
        {
            writer.WriteStartElement(null, "SttlmDtls", xmlNamespace );
            SettlementDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Extension is Extension1 ExtensionValue)
        {
            writer.WriteStartElement(null, "Xtnsn", xmlNamespace );
            ExtensionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new TransferInDetails Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
