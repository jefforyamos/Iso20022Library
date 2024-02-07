﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReorganisationInstructionDetailsSD3.  ISO2002 ID# _FD_2EMYyEeesocHIuVGr7g.
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
public partial record ReorganisationInstructionDetailsSD3
     : IIsoXmlSerilizable<ReorganisationInstructionDetailsSD3>
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    public IsoMax350Text? PlaceAndName { get; init; } 
    /// <summary>
    /// Identifies the reorganisation withdrawal transaction type.
    /// </summary>
    public ReorganisationWithdrawalTransactionType1Code? WithdrawalTransactionType { get; init; } 
    /// <summary>
    /// Unique number assigned by the depository. Transaction identification will be either the DTC instruction reference number for reorganisation instructions (VOI) or the DAM reference number for custody / reorganisation deposits.
    /// </summary>
    public IsoMax15Text? TransactionIdentification { get; init; } 
    /// <summary>
    /// Number which further identifies DTC instruction reference number. Not applicable to reorganisation / custody deposits.
    /// </summary>
    public IsoMax3NumericText? TransactionSequenceNumber { get; init; } 
    /// <summary>
    /// Identifies the protect itself or of that is being covered. It is required for the function types cover protect (COVR), cover protect directly to agent (COVA) and cover on behalf of another participant (COVP).
    /// </summary>
    public IsoMax15Text? ProtectIdentification { get; init; } 
    /// <summary>
    /// For cover protect instructions whereby one safekeeping account is covering on behalf of another safekeeping account. The protect safekeeping account will be the account which submitted the original protect instruction.
    /// </summary>
    public IsoRestrictedFINMax35Text? ProtectSafekeepingAccount { get; init; } 
    /// <summary>
    /// Provides information about securities quantity linked to a corporate action option.
    /// </summary>
    public SecuritiesQuantityDetailsSD3? SecuritiesQuantityDetails { get; init; } 
    /// <summary>
    /// Party contact information for the given instruction; required for voluntary offer instruction transaction (VOIT), protect transaction (PROT) and protect on behalf of another participant transaction (PROP); not required for cover protect instructions like cover protect transaction (COVR), cover protect directly to agent transaction (COVA) and cover protect on behalf of another participant transaction (COVP).
    /// </summary>
    public ContactIdentification5? ContactPerson { get; init; } 
    /// <summary>
    /// Customer identification entered by client upon instruction submission.
    /// </summary>
    public IsoMax30Text? CustomerReferenceIdentification { get; init; } 
    /// <summary>
    /// Unique identification of the transaction used by the transmitting party.
    /// </summary>
    public IsoMax6Text? UserReferenceNumber { get; init; } 
    
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
        if (WithdrawalTransactionType is ReorganisationWithdrawalTransactionType1Code WithdrawalTransactionTypeValue)
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
        if (ProtectIdentification is IsoMax15Text ProtectIdentificationValue)
        {
            writer.WriteStartElement(null, "PrtctId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax15Text(ProtectIdentificationValue)); // data type Max15Text System.String
            writer.WriteEndElement();
        }
        if (ProtectSafekeepingAccount is IsoRestrictedFINMax35Text ProtectSafekeepingAccountValue)
        {
            writer.WriteStartElement(null, "PrtctSfkpgAcct", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINMax35Text(ProtectSafekeepingAccountValue)); // data type RestrictedFINMax35Text System.String
            writer.WriteEndElement();
        }
        if (SecuritiesQuantityDetails is SecuritiesQuantityDetailsSD3 SecuritiesQuantityDetailsValue)
        {
            writer.WriteStartElement(null, "SctiesQtyDtls", xmlNamespace );
            SecuritiesQuantityDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ContactPerson is ContactIdentification5 ContactPersonValue)
        {
            writer.WriteStartElement(null, "CtctPrsn", xmlNamespace );
            ContactPersonValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CustomerReferenceIdentification is IsoMax30Text CustomerReferenceIdentificationValue)
        {
            writer.WriteStartElement(null, "CstmrRefId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax30Text(CustomerReferenceIdentificationValue)); // data type Max30Text System.String
            writer.WriteEndElement();
        }
        if (UserReferenceNumber is IsoMax6Text UserReferenceNumberValue)
        {
            writer.WriteStartElement(null, "UsrRefNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax6Text(UserReferenceNumberValue)); // data type Max6Text System.String
            writer.WriteEndElement();
        }
    }
    public static ReorganisationInstructionDetailsSD3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
