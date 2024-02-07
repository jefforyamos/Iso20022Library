﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountParties4.  ISO2002 ID# _RSvYTdp-Ed-ak6NoX_4Aeg_-1282825194.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Any party who is related to an investment account.
/// </summary>
public partial record AccountParties4
     : IIsoXmlSerilizable<AccountParties4>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of modification to be applied on a set of information.
    /// </summary>
    public required DataModification1Code ModificationScopeIndication { get; init; } 
    /// <summary>
    /// Single owner of the investment account or, when the ownership is split among several owners, the primary owner is the one giving its address and account details for the registration.
    /// </summary>
    public InvestmentAccountOwnershipInformation4? PrimaryOwner { get; init; } 
    /// <summary>
    /// Legal owners of the property. However, the beneficiary has the equitable or beneficial ownership.
    /// </summary>
    public ValueList<InvestmentAccountOwnershipInformation4> Trustee { get; init; } = [];
    /// <summary>
    /// Entity that holds shares/units on behalf of a legal minor. Although the account is registered under the name of the minor, the custodian retains control of the account.
    /// </summary>
    public InvestmentAccountOwnershipInformation4? CustodianForMinor { get; init; } 
    /// <summary>
    /// Entity named by the beneficial owner to act on its behalf, often to facilitate dealing, or to conceal the identity of the beneficiary.
    /// </summary>
    public InvestmentAccountOwnershipInformation4? Nominee { get; init; } 
    /// <summary>
    /// Co-owner of the investment account when the ownership is assigned to more than one party.
    /// </summary>
    public ValueList<InvestmentAccountOwnershipInformation4> JointOwner { get; init; } = [];
    /// <summary>
    /// Entity that is not the primary owner when the ownership of the investment account is split among several owners.
    /// </summary>
    public InvestmentAccountOwnershipInformation4? SecondaryOwner { get; init; } 
    /// <summary>
    /// Ultimate party that is entitled to either receive the benefits of the ownership of a financial instrument, or to be paid/credited as a result of a transfer.
    /// </summary>
    public InvestmentAccountOwnershipInformation4? Beneficiary { get; init; } 
    /// <summary>
    /// Entity that was given the authority by another entity to act on its behalf.
    /// </summary>
    public InvestmentAccountOwnershipInformation4? PowerOfAttorney { get; init; } 
    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person judged to be incapacitated.
    /// </summary>
    public InvestmentAccountOwnershipInformation4? LegalGuardian { get; init; } 
    /// <summary>
    /// Deceased's estate, or successor, to whom the respective percentage of ownership will be transferred upon the death of one of the owners.
    /// </summary>
    public InvestmentAccountOwnershipInformation4? SuccessorOnDeath { get; init; } 
    /// <summary>
    /// Entity that has been appointed by a legal authorithy to act on behalf of a person or organisation that has gone bankrupt.
    /// </summary>
    public InvestmentAccountOwnershipInformation4? Administrator { get; init; } 
    /// <summary>
    /// Granter role in the hedge funds industry.
    /// </summary>
    public ValueList<InvestmentAccountOwnershipInformation4> Granter { get; init; } = [];
    /// <summary>
    /// Settler role in the hedge funds industry.
    /// </summary>
    public ValueList<InvestmentAccountOwnershipInformation4> Settler { get; init; } = [];
    /// <summary>
    /// An other type of party.
    /// </summary>
    public ValueList<ExtendedParty1> OtherParty { get; init; } = [];
    
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
        writer.WriteStartElement(null, "ModScpIndctn", xmlNamespace );
        writer.WriteValue(ModificationScopeIndication.ToString()); // Enum value
        writer.WriteEndElement();
        if (PrimaryOwner is InvestmentAccountOwnershipInformation4 PrimaryOwnerValue)
        {
            writer.WriteStartElement(null, "PmryOwnr", xmlNamespace );
            PrimaryOwnerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Trstee", xmlNamespace );
        Trustee.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (CustodianForMinor is InvestmentAccountOwnershipInformation4 CustodianForMinorValue)
        {
            writer.WriteStartElement(null, "CtdnForMnr", xmlNamespace );
            CustodianForMinorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Nominee is InvestmentAccountOwnershipInformation4 NomineeValue)
        {
            writer.WriteStartElement(null, "Nmnee", xmlNamespace );
            NomineeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "JntOwnr", xmlNamespace );
        JointOwner.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SecondaryOwner is InvestmentAccountOwnershipInformation4 SecondaryOwnerValue)
        {
            writer.WriteStartElement(null, "ScndryOwnr", xmlNamespace );
            SecondaryOwnerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Beneficiary is InvestmentAccountOwnershipInformation4 BeneficiaryValue)
        {
            writer.WriteStartElement(null, "Bnfcry", xmlNamespace );
            BeneficiaryValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PowerOfAttorney is InvestmentAccountOwnershipInformation4 PowerOfAttorneyValue)
        {
            writer.WriteStartElement(null, "PwrOfAttny", xmlNamespace );
            PowerOfAttorneyValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LegalGuardian is InvestmentAccountOwnershipInformation4 LegalGuardianValue)
        {
            writer.WriteStartElement(null, "LglGuardn", xmlNamespace );
            LegalGuardianValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SuccessorOnDeath is InvestmentAccountOwnershipInformation4 SuccessorOnDeathValue)
        {
            writer.WriteStartElement(null, "SucssrOnDth", xmlNamespace );
            SuccessorOnDeathValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Administrator is InvestmentAccountOwnershipInformation4 AdministratorValue)
        {
            writer.WriteStartElement(null, "Admstr", xmlNamespace );
            AdministratorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Grntr", xmlNamespace );
        Granter.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Sttlr", xmlNamespace );
        Settler.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "OthrPty", xmlNamespace );
        OtherParty.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static AccountParties4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
