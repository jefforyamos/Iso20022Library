﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountReport23.  ISO2002 ID# _IlAr9W49EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reports to a corporate on the actual set-up of the account, related services and mandates.
/// </summary>
public partial record AccountReport23
     : IIsoXmlSerilizable<AccountReport23>
{
    #nullable enable
    
    /// <summary>
    /// Characteristics of the account.
    /// </summary>
    public required CustomerAccount5 Account { get; init; } 
    /// <summary>
    /// Account contract established between the organisation or the group to which the organisation belongs, and the account servicer. This contract has to be applied for the new account to be opened and maintained.
    /// </summary>
    public ContractDocument1? UnderlyingMasterAgreement { get; init; } 
    /// <summary>
    /// Specifies target and actual dates.
    /// </summary>
    public AccountContract3? ContractDates { get; init; } 
    /// <summary>
    /// Information specifying the account mandate.
    /// </summary>
    public OperationMandate4? Mandate { get; init; } 
    /// <summary>
    /// Definition of a group of parties.
    /// </summary>
    public Group4? Group { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification of the account used as a reference for the opening of another account.
    /// </summary>
    public CashAccount38? ReferenceAccount { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification of the account where to transfer the balance.
    /// </summary>
    public AccountForAction1? BalanceTransferAccount { get; init; } 
    /// <summary>
    /// Identification of the transfer account servicer.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? TransferAccountServicerIdentification { get; init; } 
    
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
        writer.WriteStartElement(null, "Acct", xmlNamespace );
        Account.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (UnderlyingMasterAgreement is ContractDocument1 UnderlyingMasterAgreementValue)
        {
            writer.WriteStartElement(null, "UndrlygMstrAgrmt", xmlNamespace );
            UnderlyingMasterAgreementValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ContractDates is AccountContract3 ContractDatesValue)
        {
            writer.WriteStartElement(null, "CtrctDts", xmlNamespace );
            ContractDatesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Mandate is OperationMandate4 MandateValue)
        {
            writer.WriteStartElement(null, "Mndt", xmlNamespace );
            MandateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Group is Group4 GroupValue)
        {
            writer.WriteStartElement(null, "Grp", xmlNamespace );
            GroupValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReferenceAccount is CashAccount38 ReferenceAccountValue)
        {
            writer.WriteStartElement(null, "RefAcct", xmlNamespace );
            ReferenceAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (BalanceTransferAccount is AccountForAction1 BalanceTransferAccountValue)
        {
            writer.WriteStartElement(null, "BalTrfAcct", xmlNamespace );
            BalanceTransferAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TransferAccountServicerIdentification is BranchAndFinancialInstitutionIdentification6 TransferAccountServicerIdentificationValue)
        {
            writer.WriteStartElement(null, "TrfAcctSvcrId", xmlNamespace );
            TransferAccountServicerIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static AccountReport23 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
