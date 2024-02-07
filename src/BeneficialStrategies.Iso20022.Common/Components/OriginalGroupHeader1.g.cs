﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OriginalGroupHeader1.  ISO2002 ID# _sniXsFkyEeGeoaLUQk__nA_1278270511.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the original group, to which the message refers.
/// </summary>
public partial record OriginalGroupHeader1
     : IIsoXmlSerilizable<OriginalGroupHeader1>
{
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the original instructing party, to unambiguously identify the original message.
    /// </summary>
    public required IsoMax35Text OriginalMessageIdentification { get; init; } 
    /// <summary>
    /// Specifies the original message name identifier to which the message refers.
    /// </summary>
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; } 
    /// <summary>
    /// Date and time at which the original message was created.
    /// </summary>
    public IsoISODateTime? OriginalCreationDateTime { get; init; } 
    /// <summary>
    /// Number of individual transactions contained in the original message.
    /// </summary>
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; } 
    /// <summary>
    /// Total of all individual amounts included in the original message, irrespective of currencies.
    /// </summary>
    public IsoDecimalNumber? OriginalControlSum { get; init; } 
    /// <summary>
    /// Specifies the status of a group of transactions.
    /// </summary>
    public TransactionGroupStatus3Code? GroupStatus { get; init; } 
    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    public StatusReasonInformation9? StatusReasonInformation { get; init; } 
    /// <summary>
    /// Detailed information on the number of transactions for each identical transaction status.
    /// </summary>
    public NumberOfTransactionsPerStatus3? NumberOfTransactionsPerStatus { get; init; } 
    
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
        writer.WriteStartElement(null, "OrgnlMsgId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(OriginalMessageIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "OrgnlMsgNmId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(OriginalMessageNameIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (OriginalCreationDateTime is IsoISODateTime OriginalCreationDateTimeValue)
        {
            writer.WriteStartElement(null, "OrgnlCreDtTm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(OriginalCreationDateTimeValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (OriginalNumberOfTransactions is IsoMax15NumericText OriginalNumberOfTransactionsValue)
        {
            writer.WriteStartElement(null, "OrgnlNbOfTxs", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax15NumericText(OriginalNumberOfTransactionsValue)); // data type Max15NumericText System.String
            writer.WriteEndElement();
        }
        if (OriginalControlSum is IsoDecimalNumber OriginalControlSumValue)
        {
            writer.WriteStartElement(null, "OrgnlCtrlSum", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoDecimalNumber(OriginalControlSumValue)); // data type DecimalNumber System.UInt64
            writer.WriteEndElement();
        }
        if (GroupStatus is TransactionGroupStatus3Code GroupStatusValue)
        {
            writer.WriteStartElement(null, "GrpSts", xmlNamespace );
            writer.WriteValue(GroupStatusValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (StatusReasonInformation is StatusReasonInformation9 StatusReasonInformationValue)
        {
            writer.WriteStartElement(null, "StsRsnInf", xmlNamespace );
            StatusReasonInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NumberOfTransactionsPerStatus is NumberOfTransactionsPerStatus3 NumberOfTransactionsPerStatusValue)
        {
            writer.WriteStartElement(null, "NbOfTxsPerSts", xmlNamespace );
            NumberOfTransactionsPerStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static OriginalGroupHeader1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
