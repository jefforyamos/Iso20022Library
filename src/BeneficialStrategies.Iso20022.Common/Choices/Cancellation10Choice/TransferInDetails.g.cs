﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for TransferInDetails.  ISO2002 ID# _5ImlEyPvEeWQjryFgN2ITg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.Cancellation10Choice;

/// <summary>
/// Details of the transfer in request to cancel.
/// </summary>
public partial record TransferInDetails : Cancellation10Choice_
     , IIsoXmlSerilizable<TransferInDetails>
{
    #nullable enable
    
    /// <summary>
    /// Requested date at which the instructing party places the transfer instruction.
    /// </summary>
    public DateFormat1Choice_? RequestedTransferDate { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    public IsoMax35Text? MasterReference { get; init; } 
    /// <summary>
    /// Details of the transfer and cancellation.
    /// </summary>
    public TransferIn16? TransferAndReferences { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _5lLMWSPvEeWQjryFgN2ITg
    /// <summary>
    /// Information related to the account into which the financial instrument is to be received.
    /// </summary>
    public required InvestmentAccount56 AccountDetails { get; init; } 
    /// <summary>
    /// Information related to the delivering side of the transfer.
    /// </summary>
    public DeliverInformation16? SettlementDetails { get; init; } 
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
        if (RequestedTransferDate is DateFormat1Choice_ RequestedTransferDateValue)
        {
            writer.WriteStartElement(null, "ReqdTrfDt", xmlNamespace );
            RequestedTransferDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MasterReference is IsoMax35Text MasterReferenceValue)
        {
            writer.WriteStartElement(null, "MstrRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(MasterReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        // Not sure how to serialize TransferAndReferences, multiplicity Unknown
        writer.WriteStartElement(null, "AcctDtls", xmlNamespace );
        AccountDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SettlementDetails is DeliverInformation16 SettlementDetailsValue)
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
