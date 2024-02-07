﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OriginalPaymentInstruction42.  ISO2002 ID# _cdiBcdcZEeqRFcf2R4bPBw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the original transactions, to which the status report message refers.
/// </summary>
public partial record OriginalPaymentInstruction42
     : IIsoXmlSerilizable<OriginalPaymentInstruction42>
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the original sending party, to unambiguously identify the original payment information group.
    /// </summary>
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; } 
    /// <summary>
    /// Number of individual transactions contained in the original payment information group.
    /// </summary>
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; } 
    /// <summary>
    /// Total of all individual amounts included in the original payment information group, irrespective of currencies.
    /// </summary>
    public IsoDecimalNumber? OriginalControlSum { get; init; } 
    /// <summary>
    /// Specifies the status of the payment information group.
    /// </summary>
    public ExternalPaymentGroupStatus1Code? PaymentInformationStatus { get; init; } 
    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    public StatusReasonInformation12? StatusReasonInformation { get; init; } 
    /// <summary>
    /// Detailed information on the number of transactions for each identical transaction status.
    /// </summary>
    public NumberOfTransactionsPerStatus5? NumberOfTransactionsPerStatus { get; init; } 
    /// <summary>
    /// Provides information on the original transactions to which the status report message refers.
    /// </summary>
    public PaymentTransaction136? TransactionInformationAndStatus { get; init; } 
    
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
        writer.WriteStartElement(null, "OrgnlPmtInfId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(OriginalPaymentInformationIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
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
        if (PaymentInformationStatus is ExternalPaymentGroupStatus1Code PaymentInformationStatusValue)
        {
            writer.WriteStartElement(null, "PmtInfSts", xmlNamespace );
            writer.WriteValue(PaymentInformationStatusValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (StatusReasonInformation is StatusReasonInformation12 StatusReasonInformationValue)
        {
            writer.WriteStartElement(null, "StsRsnInf", xmlNamespace );
            StatusReasonInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NumberOfTransactionsPerStatus is NumberOfTransactionsPerStatus5 NumberOfTransactionsPerStatusValue)
        {
            writer.WriteStartElement(null, "NbOfTxsPerSts", xmlNamespace );
            NumberOfTransactionsPerStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TransactionInformationAndStatus is PaymentTransaction136 TransactionInformationAndStatusValue)
        {
            writer.WriteStartElement(null, "TxInfAndSts", xmlNamespace );
            TransactionInformationAndStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static OriginalPaymentInstruction42 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
