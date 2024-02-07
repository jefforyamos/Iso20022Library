﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountParties10.  ISO2002 ID# _C5k64QhDEeSUPbC7DbLJpQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a party's account.
/// </summary>
public partial record AccountParties10
     : IIsoXmlSerilizable<AccountParties10>
{
    #nullable enable
    
    /// <summary>
    /// Main party associated with the account.
    /// </summary>
    public required AccountParties5Choice_ PrincipalAccountParty { get; init; } 
    /// <summary>
    /// Entity that is not the primary owner when the ownership of the investment account is split among several owners.
    /// </summary>
    public InvestmentAccountOwnershipInformation10? SecondaryOwner { get; init; } 
    /// <summary>
    /// Ultimate party that is entitled to either receive the benefits of the ownership of a financial instrument, or to be paid/credited as a result of a transfer.
    /// </summary>
    public InvestmentAccountOwnershipInformation10? Beneficiary { get; init; } 
    /// <summary>
    /// Entity that was given the authority by another entity to act on its behalf.
    /// </summary>
    public InvestmentAccountOwnershipInformation10? PowerOfAttorney { get; init; } 
    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person judged to be incapacitated.
    /// </summary>
    public InvestmentAccountOwnershipInformation10? LegalGuardian { get; init; } 
    /// <summary>
    /// Deceased's estate, or successor, to whom the respective percentage of ownership will be transferred upon the death of one of the owners.
    /// </summary>
    public ValueList<InvestmentAccountOwnershipInformation10> SuccessorOnDeath { get; init; } = [];
    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person or organisation that has gone bankrupt.
    /// </summary>
    public InvestmentAccountOwnershipInformation10? Administrator { get; init; } 
    /// <summary>
    /// Other type of party.
    /// </summary>
    public ExtendedParty7? OtherParty { get; init; } 
    /// <summary>
    /// Granter role in the hedge funds industry.
    /// </summary>
    public ValueList<InvestmentAccountOwnershipInformation10> Granter { get; init; } = [];
    /// <summary>
    /// Entity that creates a trust or contributes assets to the trust.
    /// </summary>
    public ValueList<InvestmentAccountOwnershipInformation10> Settlor { get; init; } = [];
    
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
        writer.WriteStartElement(null, "PrncplAcctPty", xmlNamespace );
        PrincipalAccountParty.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SecondaryOwner is InvestmentAccountOwnershipInformation10 SecondaryOwnerValue)
        {
            writer.WriteStartElement(null, "ScndryOwnr", xmlNamespace );
            SecondaryOwnerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Beneficiary is InvestmentAccountOwnershipInformation10 BeneficiaryValue)
        {
            writer.WriteStartElement(null, "Bnfcry", xmlNamespace );
            BeneficiaryValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PowerOfAttorney is InvestmentAccountOwnershipInformation10 PowerOfAttorneyValue)
        {
            writer.WriteStartElement(null, "PwrOfAttny", xmlNamespace );
            PowerOfAttorneyValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LegalGuardian is InvestmentAccountOwnershipInformation10 LegalGuardianValue)
        {
            writer.WriteStartElement(null, "LglGuardn", xmlNamespace );
            LegalGuardianValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SucssrOnDth", xmlNamespace );
        SuccessorOnDeath.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Administrator is InvestmentAccountOwnershipInformation10 AdministratorValue)
        {
            writer.WriteStartElement(null, "Admstr", xmlNamespace );
            AdministratorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OtherParty is ExtendedParty7 OtherPartyValue)
        {
            writer.WriteStartElement(null, "OthrPty", xmlNamespace );
            OtherPartyValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Grntr", xmlNamespace );
        Granter.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Sttlr", xmlNamespace );
        Settlor.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static AccountParties10 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
