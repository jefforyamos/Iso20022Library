﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OriginalPaymentInformation3.  ISO2002 ID# _PmG3Xdp-Ed-ak6NoX_4Aeg_-1414031304.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide reference and status information on the original transactions, included in the original instruction, to which the cancellation request message applies.
/// </summary>
public partial record OriginalPaymentInformation3
     : IIsoXmlSerilizable<OriginalPaymentInformation3>
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the original assigner, to unambiguously identify the original payment information cancellation request.
    /// </summary>
    public IsoMax35Text? OriginalPaymentInformationCancellationIdentification { get; init; } 
    /// <summary>
    /// Identifies the resolved case.
    /// </summary>
    public Case2? ResolvedCase { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the original sending party, to unambiguously identify the original payment information group.
    /// </summary>
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; } 
    /// <summary>
    /// Set of elements used to provide information on the original messsage.
    /// </summary>
    public OriginalGroupInformation3? OriginalGroupInformation { get; init; } 
    /// <summary>
    /// Number of individual transactions contained in the original payment information group.
    /// </summary>
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; } 
    /// <summary>
    /// Total of all individual amounts included in the original payment information group, irrespective of currencies.
    /// </summary>
    public IsoDecimalNumber? OriginalControlSum { get; init; } 
    /// <summary>
    /// Specifies the status of a cancellation request, related to a payment information group.
    /// </summary>
    public GroupCancellationStatus1Code? PaymentInformationCancellationStatus { get; init; } 
    /// <summary>
    /// Set of elements used to provide detailed information on the cancellation status reason.
    /// </summary>
    public CancellationStatusReasonInformation1? CancellationStatusReasonInformation { get; init; } 
    /// <summary>
    /// Detailed information on the number of transactions for each identical cancellation status.
    /// </summary>
    public NumberOfCancellationsPerStatus1? NumberOfTransactionsPerCancellationStatus { get; init; } 
    /// <summary>
    /// Set of elements used to provide information on the original transactions to which the cancellation request message refers.
    /// </summary>
    public PaymentTransactionInformation32? TransactionInformationAndStatus { get; init; } 
    
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
        if (OriginalPaymentInformationCancellationIdentification is IsoMax35Text OriginalPaymentInformationCancellationIdentificationValue)
        {
            writer.WriteStartElement(null, "OrgnlPmtInfCxlId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OriginalPaymentInformationCancellationIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ResolvedCase is Case2 ResolvedCaseValue)
        {
            writer.WriteStartElement(null, "RslvdCase", xmlNamespace );
            ResolvedCaseValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "OrgnlPmtInfId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(OriginalPaymentInformationIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (OriginalGroupInformation is OriginalGroupInformation3 OriginalGroupInformationValue)
        {
            writer.WriteStartElement(null, "OrgnlGrpInf", xmlNamespace );
            OriginalGroupInformationValue.Serialize(writer, xmlNamespace);
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
        if (PaymentInformationCancellationStatus is GroupCancellationStatus1Code PaymentInformationCancellationStatusValue)
        {
            writer.WriteStartElement(null, "PmtInfCxlSts", xmlNamespace );
            writer.WriteValue(PaymentInformationCancellationStatusValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (CancellationStatusReasonInformation is CancellationStatusReasonInformation1 CancellationStatusReasonInformationValue)
        {
            writer.WriteStartElement(null, "CxlStsRsnInf", xmlNamespace );
            CancellationStatusReasonInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NumberOfTransactionsPerCancellationStatus is NumberOfCancellationsPerStatus1 NumberOfTransactionsPerCancellationStatusValue)
        {
            writer.WriteStartElement(null, "NbOfTxsPerCxlSts", xmlNamespace );
            NumberOfTransactionsPerCancellationStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TransactionInformationAndStatus is PaymentTransactionInformation32 TransactionInformationAndStatusValue)
        {
            writer.WriteStartElement(null, "TxInfAndSts", xmlNamespace );
            TransactionInformationAndStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static OriginalPaymentInformation3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
