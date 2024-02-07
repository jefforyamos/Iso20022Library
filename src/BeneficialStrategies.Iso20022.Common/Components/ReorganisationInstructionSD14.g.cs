﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReorganisationInstructionSD14.  ISO2002 ID# _28WeYVCEEe2KGNXAcFL5RA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action reorganisation instruction details.
/// </summary>
public partial record ReorganisationInstructionSD14
     : IIsoXmlSerilizable<ReorganisationInstructionSD14>
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    public IsoMax350Text? PlaceAndName { get; init; } 
    /// <summary>
    /// Identifies the reorganisation withdrawal transaction type.
    /// </summary>
    public ReorganisationWithdrawalTransactionType2Code? WithdrawalTransactionType { get; init; } 
    /// <summary>
    /// Unique number assigned by the depository. Transaction identification will be either the DTC instruction reference number for reorganisation instructions (VOI) or the DAM reference number for custody / reorganisation deposits.
    /// </summary>
    public IsoMax15Text? TransactionIdentification { get; init; } 
    /// <summary>
    /// Number which further identifies DTC instruction reference number. Not applicable to reorganisation / custody deposits.
    /// </summary>
    public IsoMax3NumericText? TransactionSequenceNumber { get; init; } 
    /// <summary>
    /// Status of the instruction.
    /// </summary>
    public DTCInstructionStatus2Code? TransactionIdentificationStatus { get; init; } 
    /// <summary>
    /// Provides information about securities quantity linked to a corporate action option.
    /// </summary>
    public SecuritiesQuantitySD6? SecuritiesQuantityDetails { get; init; } 
    /// <summary>
    /// Reason for which an inbound instruction message or a cancellation instruction message is rejected.
    /// </summary>
    public SimpleValueList<InstructionRejectionReason3Code> RejectionReason { get; init; } = [];
    /// <summary>
    /// Customer identification entered by client upon instruction submission.
    /// </summary>
    public IsoMax30Text? CustomerReferenceIdentification { get; init; } 
    /// <summary>
    /// Party contact information for the given instruction.
    /// </summary>
    public ContactIdentification5? ContactPerson { get; init; } 
    /// <summary>
    /// Unique identification of the transaction used by the transmitting party.
    /// </summary>
    public IsoMax6Text? UserReferenceNumber { get; init; } 
    /// <summary>
    /// For cover protect instructions whereby one safekeeping account is covering on behalf of another safekeeping account. The protect safekeeping account will be the account which submitted the original protect instruction.
    /// </summary>
    public IsoRestrictedFINMax35Text? ProtectSafekeepingAccount { get; init; } 
    /// <summary>
    /// Status of the protect instruction.
    /// </summary>
    public DTCProtectInstructionStatus1Code? ProtectTransactionStatus { get; init; } 
    
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
        if (PlaceAndName is IsoMax350Text PlaceAndNameValue)
        {
            writer.WriteStartElement(null, "PlcAndNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(PlaceAndNameValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        if (WithdrawalTransactionType is ReorganisationWithdrawalTransactionType2Code WithdrawalTransactionTypeValue)
        {
            writer.WriteStartElement(null, "WdrwlTxTp", xmlNamespace );
            writer.WriteValue(WithdrawalTransactionTypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (TransactionIdentification is IsoMax15Text TransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "TxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax15Text(TransactionIdentificationValue)); // data type Max15Text System.String
            writer.WriteEndElement();
        }
        if (TransactionSequenceNumber is IsoMax3NumericText TransactionSequenceNumberValue)
        {
            writer.WriteStartElement(null, "TxSeqNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax3NumericText(TransactionSequenceNumberValue)); // data type Max3NumericText System.String
            writer.WriteEndElement();
        }
        if (TransactionIdentificationStatus is DTCInstructionStatus2Code TransactionIdentificationStatusValue)
        {
            writer.WriteStartElement(null, "TxIdSts", xmlNamespace );
            writer.WriteValue(TransactionIdentificationStatusValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (SecuritiesQuantityDetails is SecuritiesQuantitySD6 SecuritiesQuantityDetailsValue)
        {
            writer.WriteStartElement(null, "SctiesQtyDtls", xmlNamespace );
            SecuritiesQuantityDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "RjctnRsn", xmlNamespace );
        writer.WriteValue(RejectionReason.ToString()); // Enum value
        writer.WriteEndElement();
        if (CustomerReferenceIdentification is IsoMax30Text CustomerReferenceIdentificationValue)
        {
            writer.WriteStartElement(null, "CstmrRefId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax30Text(CustomerReferenceIdentificationValue)); // data type Max30Text System.String
            writer.WriteEndElement();
        }
        if (ContactPerson is ContactIdentification5 ContactPersonValue)
        {
            writer.WriteStartElement(null, "CtctPrsn", xmlNamespace );
            ContactPersonValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (UserReferenceNumber is IsoMax6Text UserReferenceNumberValue)
        {
            writer.WriteStartElement(null, "UsrRefNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax6Text(UserReferenceNumberValue)); // data type Max6Text System.String
            writer.WriteEndElement();
        }
        if (ProtectSafekeepingAccount is IsoRestrictedFINMax35Text ProtectSafekeepingAccountValue)
        {
            writer.WriteStartElement(null, "PrtctSfkpgAcct", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINMax35Text(ProtectSafekeepingAccountValue)); // data type RestrictedFINMax35Text System.String
            writer.WriteEndElement();
        }
        if (ProtectTransactionStatus is DTCProtectInstructionStatus1Code ProtectTransactionStatusValue)
        {
            writer.WriteStartElement(null, "PrtctTxSts", xmlNamespace );
            writer.WriteValue(ProtectTransactionStatusValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static ReorganisationInstructionSD14 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
