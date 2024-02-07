﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentTransaction46.  ISO2002 ID# _7dgOUSHQEeKGep4bhmamiA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the original transactions, to which the status report message refers.
/// </summary>
public partial record PaymentTransaction46
     : IIsoXmlSerilizable<PaymentTransaction46>
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the reported status.|Usage: The instructing party is the party sending the status message and not the party that sent the original instruction that is being reported on.
    /// </summary>
    public IsoMax35Text? StatusIdentification { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    public IsoMax35Text? OriginalInstructionIdentification { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; } 
    /// <summary>
    /// Specifies the status of a transaction, in a coded form.
    /// </summary>
    public TransactionIndividualStatus3Code? TransactionStatus { get; init; } 
    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    public StatusReasonInformation9? StatusReasonInformation { get; init; } 
    /// <summary>
    /// Provides information on the charges related to the processing of the rejection of the instruction.|Usage: This is passed on for information purposes only. Settlement of the charges will be done separately.
    /// </summary>
    public Charges2? ChargesInformation { get; init; } 
    /// <summary>
    /// Point in time when the payment order from the initiating party meets the processing conditions of the account servicing agent. This means that the account servicing agent has received the payment order and has applied checks such as authorisation, availability of funds.
    /// </summary>
    public IsoISODateTime? AcceptanceDateTime { get; init; } 
    /// <summary>
    /// Unique reference, as assigned by the account servicing institution, to unambiguously identify the instruction.
    /// </summary>
    public IsoMax35Text? AccountServicerReference { get; init; } 
    /// <summary>
    /// Unique reference, as assigned by a clearing system, to unambiguously identify the instruction.
    /// </summary>
    public IsoMax35Text? ClearingSystemReference { get; init; } 
    /// <summary>
    /// Key elements used to identify the original transaction that is being referred to.
    /// </summary>
    public OriginalTransactionReference16? OriginalTransactionReference { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init; } 
    
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
        if (StatusIdentification is IsoMax35Text StatusIdentificationValue)
        {
            writer.WriteStartElement(null, "StsId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(StatusIdentificationValue)); // data type Max35Text System.String
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
        if (TransactionStatus is TransactionIndividualStatus3Code TransactionStatusValue)
        {
            writer.WriteStartElement(null, "TxSts", xmlNamespace );
            writer.WriteValue(TransactionStatusValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (StatusReasonInformation is StatusReasonInformation9 StatusReasonInformationValue)
        {
            writer.WriteStartElement(null, "StsRsnInf", xmlNamespace );
            StatusReasonInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ChargesInformation is Charges2 ChargesInformationValue)
        {
            writer.WriteStartElement(null, "ChrgsInf", xmlNamespace );
            ChargesInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AcceptanceDateTime is IsoISODateTime AcceptanceDateTimeValue)
        {
            writer.WriteStartElement(null, "AccptncDtTm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(AcceptanceDateTimeValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (AccountServicerReference is IsoMax35Text AccountServicerReferenceValue)
        {
            writer.WriteStartElement(null, "AcctSvcrRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(AccountServicerReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ClearingSystemReference is IsoMax35Text ClearingSystemReferenceValue)
        {
            writer.WriteStartElement(null, "ClrSysRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ClearingSystemReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (OriginalTransactionReference is OriginalTransactionReference16 OriginalTransactionReferenceValue)
        {
            writer.WriteStartElement(null, "OrgnlTxRef", xmlNamespace );
            OriginalTransactionReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PaymentTransaction46 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
