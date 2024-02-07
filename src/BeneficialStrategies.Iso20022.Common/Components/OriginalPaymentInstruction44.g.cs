﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OriginalPaymentInstruction44.  ISO2002 ID# _g67Z4dcZEeqRFcf2R4bPBw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the reference and status of the original transactions, included in the original instruction, to which the cancellation request message applies.
/// </summary>
public partial record OriginalPaymentInstruction44
     : IIsoXmlSerilizable<OriginalPaymentInstruction44>
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the assigner, to unambiguously identify the cancellation request.||Usage: The cancellation request identification can be used for reconciliation or to link tasks relating to the cancellation request.
    /// </summary>
    public IsoMax35Text? PaymentCancellationIdentification { get; init; } 
    /// <summary>
    /// Identifies the case.
    /// </summary>
    public Case5? Case { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier of the original payment information block, as assigned by the original sending party.
    /// </summary>
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; } 
    /// <summary>
    /// Information concerning the original group of transactions, to which the message refers.
    /// </summary>
    public OriginalGroupInformation29? OriginalGroupInformation { get; init; } 
    /// <summary>
    /// Number of individual transactions contained in the cancellation payment information group.
    /// </summary>
    public IsoMax15NumericText? NumberOfTransactions { get; init; } 
    /// <summary>
    /// Total of all individual amounts included in the cancellation payment information group, irrespective of currencies.
    /// </summary>
    public IsoDecimalNumber? ControlSum { get; init; } 
    /// <summary>
    /// Indicates whether or not the cancellation applies to a whole group of transactions or to individual transactions within the original group.
    /// </summary>
    public IsoGroupCancellationIndicator? PaymentInformationCancellation { get; init; } 
    /// <summary>
    /// Detailed information on the cancellation reason.
    /// </summary>
    public PaymentCancellationReason5? CancellationReasonInformation { get; init; } 
    /// <summary>
    /// Information concerning the original transactions, to which the cancellation request message refers.
    /// </summary>
    public PaymentTransaction140? TransactionInformation { get; init; } 
    
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
        if (PaymentCancellationIdentification is IsoMax35Text PaymentCancellationIdentificationValue)
        {
            writer.WriteStartElement(null, "PmtCxlId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(PaymentCancellationIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (Case is Case5 CaseValue)
        {
            writer.WriteStartElement(null, "Case", xmlNamespace );
            CaseValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "OrgnlPmtInfId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(OriginalPaymentInformationIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (OriginalGroupInformation is OriginalGroupInformation29 OriginalGroupInformationValue)
        {
            writer.WriteStartElement(null, "OrgnlGrpInf", xmlNamespace );
            OriginalGroupInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NumberOfTransactions is IsoMax15NumericText NumberOfTransactionsValue)
        {
            writer.WriteStartElement(null, "NbOfTxs", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax15NumericText(NumberOfTransactionsValue)); // data type Max15NumericText System.String
            writer.WriteEndElement();
        }
        if (ControlSum is IsoDecimalNumber ControlSumValue)
        {
            writer.WriteStartElement(null, "CtrlSum", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoDecimalNumber(ControlSumValue)); // data type DecimalNumber System.UInt64
            writer.WriteEndElement();
        }
        if (PaymentInformationCancellation is IsoGroupCancellationIndicator PaymentInformationCancellationValue)
        {
            writer.WriteStartElement(null, "PmtInfCxl", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoGroupCancellationIndicator(PaymentInformationCancellationValue)); // data type GroupCancellationIndicator System.String
            writer.WriteEndElement();
        }
        if (CancellationReasonInformation is PaymentCancellationReason5 CancellationReasonInformationValue)
        {
            writer.WriteStartElement(null, "CxlRsnInf", xmlNamespace );
            CancellationReasonInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TransactionInformation is PaymentTransaction140 TransactionInformationValue)
        {
            writer.WriteStartElement(null, "TxInf", xmlNamespace );
            TransactionInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static OriginalPaymentInstruction44 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
