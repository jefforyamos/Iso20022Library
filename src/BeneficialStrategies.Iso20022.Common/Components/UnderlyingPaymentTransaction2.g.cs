﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UnderlyingPaymentTransaction2.  ISO2002 ID# _P3EMU59XEeGBX4a4yy-WHg_1772426140.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reference information concerning the original transaction, to which the investigation message refers.
/// </summary>
public partial record UnderlyingPaymentTransaction2
     : IIsoXmlSerilizable<UnderlyingPaymentTransaction2>
{
    #nullable enable
    
    /// <summary>
    /// Set of elements used to provide information on the original message.
    /// </summary>
    public UnderlyingGroupInformation1? OriginalGroupInformation { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    public IsoMax35Text? OriginalInstructionIdentification { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the original first instructing agent, to unambiguously identify the transaction.
    /// </summary>
    public IsoMax35Text? OriginalTransactionIdentification { get; init; } 
    /// <summary>
    /// Amount of money, as provided in the original transaction, to be moved between the instructing agent and the instructed agent.
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount OriginalInterbankSettlementAmount { get; init; } 
    /// <summary>
    /// Date, as provided in the original transaction, on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    public required IsoISODate OriginalInterbankSettlementDate { get; init; } 
    
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
        if (OriginalTransactionIdentification is IsoMax35Text OriginalTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "OrgnlTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OriginalTransactionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "OrgnlIntrBkSttlmAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(OriginalInterbankSettlementAmount)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "OrgnlIntrBkSttlmDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(OriginalInterbankSettlementDate)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
    }
    public static UnderlyingPaymentTransaction2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
