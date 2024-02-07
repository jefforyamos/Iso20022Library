﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Initiation.  ISO2002 ID# _3rWFwXuSEeivKIBRHeTQRQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.CorrectiveTransaction4Choice;

/// <summary>
/// Set of elements used to reference the details of the corrective payment initiation.
/// </summary>
public partial record Initiation : CorrectiveTransaction4Choice_
     , IIsoXmlSerilizable<Initiation>
{
    #nullable enable
    
    /// <summary>
    /// Set of elements used to provide corrective information for the group header of the message under investigation.
    /// </summary>
    public CorrectiveGroupInformation1? GroupHeader { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by a sending party, to unambiguously identify the payment information group within the message.
    /// </summary>
    public IsoMax35Text? PaymentInformationIdentification { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the instruction.||Usage: The instruction identification is a point to point reference that can be used between the instructing party and the instructed party to refer to the individual instruction. It can be included in several messages related to the instruction.
    /// </summary>
    public IsoMax35Text? InstructionIdentification { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the initiating party, to unambiguously identify the transaction. This identification is passed on, unchanged, throughout the entire end-to-end chain.||Usage: The end-to-end identification can be used for reconciliation or to link tasks relating to the transaction. It can be included in several messages related to the transaction.||Usage: In case there are technical limitations to pass on multiple references, the end-to-end identification must be passed on throughout the entire end-to-end chain.
    /// </summary>
    public IsoMax35Text? EndToEndIdentification { get; init; } 
    /// <summary>
    /// Universally unique identifier to provide an end-to-end reference of a payment transaction.
    /// </summary>
    public IsoUUIDv4Identifier? UETR { get; init; } 
    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount InstructedAmount { get; init; } 
    /// <summary>
    /// Date or date time at which the initiating party requests the clearing agent to process the payment. 
    /// Usage: This is the date or date time on which the debtor's account is to be debited. If payment by cheque, the date when the cheque must be generated by the bank.
    /// </summary>
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; init; } 
    /// <summary>
    /// Date at which the creditor requests the amount of money to be collected from the debtor.
    /// </summary>
    public IsoISODate? RequestedCollectionDate { get; init; } 
    
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
        if (GroupHeader is CorrectiveGroupInformation1 GroupHeaderValue)
        {
            writer.WriteStartElement(null, "GrpHdr", xmlNamespace );
            GroupHeaderValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PaymentInformationIdentification is IsoMax35Text PaymentInformationIdentificationValue)
        {
            writer.WriteStartElement(null, "PmtInfId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(PaymentInformationIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (InstructionIdentification is IsoMax35Text InstructionIdentificationValue)
        {
            writer.WriteStartElement(null, "InstrId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(InstructionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (EndToEndIdentification is IsoMax35Text EndToEndIdentificationValue)
        {
            writer.WriteStartElement(null, "EndToEndId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(EndToEndIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (UETR is IsoUUIDv4Identifier UETRValue)
        {
            writer.WriteStartElement(null, "UETR", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoUUIDv4Identifier(UETRValue)); // data type UUIDv4Identifier System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "InstdAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(InstructedAmount)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        if (RequestedExecutionDate is DateAndDateTime2Choice_ RequestedExecutionDateValue)
        {
            writer.WriteStartElement(null, "ReqdExctnDt", xmlNamespace );
            RequestedExecutionDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RequestedCollectionDate is IsoISODate RequestedCollectionDateValue)
        {
            writer.WriteStartElement(null, "ReqdColltnDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(RequestedCollectionDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
    }
    public static new Initiation Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
