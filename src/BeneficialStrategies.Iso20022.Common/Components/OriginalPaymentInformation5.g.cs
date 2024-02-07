﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OriginalPaymentInformation5.  ISO2002 ID# _PezVcNp-Ed-ak6NoX_4Aeg_-1733791998.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the original transactions, to which the status report message refers.
/// </summary>
public partial record OriginalPaymentInformation5
     : IIsoXmlSerilizable<OriginalPaymentInformation5>
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
    public TransactionGroupStatus3Code? PaymentInformationStatus { get; init; } 
    /// <summary>
    /// Set of elements used to provide detailed information on the status reason.
    /// </summary>
    public StatusReasonInformation9? StatusReasonInformation { get; init; } 
    /// <summary>
    /// Detailed information on the number of transactions for each identical transaction status.
    /// </summary>
    public NumberOfTransactionsPerStatus3? NumberOfTransactionsPerStatus { get; init; } 
    /// <summary>
    /// Set of elements used to provide information on the original transactions to which the status report message refers.
    /// </summary>
    public PaymentTransactionInformation34? TransactionInformationAndStatus { get; init; } 
    
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
        if (PaymentInformationStatus is TransactionGroupStatus3Code PaymentInformationStatusValue)
        {
            writer.WriteStartElement(null, "PmtInfSts", xmlNamespace );
            writer.WriteValue(PaymentInformationStatusValue.ToString()); // Enum value
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
        if (TransactionInformationAndStatus is PaymentTransactionInformation34 TransactionInformationAndStatusValue)
        {
            writer.WriteStartElement(null, "TxInfAndSts", xmlNamespace );
            TransactionInformationAndStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static OriginalPaymentInformation5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
