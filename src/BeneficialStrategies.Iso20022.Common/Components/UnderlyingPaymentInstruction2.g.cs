﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UnderlyingPaymentInstruction2.  ISO2002 ID# _P2ngYJ9XEeGBX4a4yy-WHg_1684904814.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reference information concerning the original payment initiation, to which the investigation message refers.
/// </summary>
public partial record UnderlyingPaymentInstruction2
     : IIsoXmlSerilizable<UnderlyingPaymentInstruction2>
{
    #nullable enable
    
    /// <summary>
    /// Set of elements used to provide information on the original message.
    /// </summary>
    public UnderlyingGroupInformation1? OriginalGroupInformation { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the original sending party, to unambiguously identify the original payment information group.
    /// </summary>
    public IsoMax35Text? OriginalPaymentInformationIdentification { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    public IsoMax35Text? OriginalInstructionIdentification { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; } 
    /// <summary>
    /// Amount of money, as provided in the original transaction, to be moved between the debtor and the creditor, before deduction of charges, expressed in the currency, as ordered by the original initiating party.
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount OriginalInstructedAmount { get; init; } 
    /// <summary>
    /// Date at which the initiating party requests the clearing agent to process the payment. |Usage: This is the date on which the debtor's account is to be debited. If payment by cheque, the date when the cheque must be generated by the bank.
    /// </summary>
    public IsoISODate? RequestedExecutionDate { get; init; } 
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
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (OriginalGroupInformation is UnderlyingGroupInformation1 OriginalGroupInformationValue)
        {
            writer.WriteStartElement(null, "OrgnlGrpInf", xmlNamespace );
            OriginalGroupInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OriginalPaymentInformationIdentification is IsoMax35Text OriginalPaymentInformationIdentificationValue)
        {
            writer.WriteStartElement(null, "OrgnlPmtInfId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OriginalPaymentInformationIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (OriginalInstructionIdentification is IsoMax35Text OriginalInstructionIdentificationValue)
        {
            writer.WriteStartElement(null, "OrgnlInstrId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OriginalInstructionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (OriginalEndToEndIdentification is IsoMax35Text OriginalEndToEndIdentificationValue)
        {
            writer.WriteStartElement(null, "OrgnlEndToEndId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OriginalEndToEndIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "OrgnlInstdAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(OriginalInstructedAmount)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        if (RequestedExecutionDate is IsoISODate RequestedExecutionDateValue)
        {
            writer.WriteStartElement(null, "ReqdExctnDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(RequestedExecutionDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (RequestedCollectionDate is IsoISODate RequestedCollectionDateValue)
        {
            writer.WriteStartElement(null, "ReqdColltnDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(RequestedCollectionDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
    }
    public static UnderlyingPaymentInstruction2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
