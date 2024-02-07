﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountParties6.  ISO2002 ID# _vypW0ROEEeKjmvxNCObNeQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party related to an investment account.
/// </summary>
public partial record AccountParties6
     : IIsoXmlSerilizable<AccountParties6>
{
    #nullable enable
    
    /// <summary>
    /// Main party associated with the account.
    /// </summary>
    public required AccountParties1Choice_ PrincipalAccountParty { get; init; } 
    /// <summary>
    /// Entity that is not the primary owner when the ownership of the investment account is split among several owners.
    /// </summary>
    public ValueList<InvestmentAccountOwnershipInformation6> SecondaryOwner { get; init; } = [];
    /// <summary>
    /// Ultimate party that is entitled to either receive the benefits of the ownership of a financial instrument, or to be paid/credited as a result of a transfer.
    /// </summary>
    public ValueList<InvestmentAccountOwnershipInformation6> Beneficiary { get; init; } = [];
    /// <summary>
    /// Entity that was given the authority by another entity to act on its behalf.
    /// </summary>
    public ValueList<InvestmentAccountOwnershipInformation6> PowerOfAttorney { get; init; } = [];
    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person judged to be incapacitated.
    /// </summary>
    public ValueList<InvestmentAccountOwnershipInformation6> LegalGuardian { get; init; } = [];
    /// <summary>
    /// Deceased's estate, or successor, to whom the respective percentage of ownership will be transferred upon the death of one of the owners.
    /// </summary>
    public ValueList<InvestmentAccountOwnershipInformation6> SuccessorOnDeath { get; init; } = [];
    /// <summary>
    /// Entity that has been appointed by a legal authorithy to act on behalf of a person or organisation that has gone bankrupt.
    /// </summary>
    public InvestmentAccountOwnershipInformation6? Administrator { get; init; } 
    /// <summary>
    /// Other type of party.
    /// </summary>
    public ValueList<ExtendedParty3> OtherParty { get; init; } = [];
    /// <summary>
    /// Granter role in the hedge funds industry.
    /// </summary>
    public ValueList<InvestmentAccountOwnershipInformation6> Granter { get; init; } = [];
    /// <summary>
    /// Settler role in the hedge funds industry.
    /// </summary>
    public ValueList<InvestmentAccountOwnershipInformation6> Settler { get; init; } = [];
    
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
        writer.WriteStartElement(null, "ScndryOwnr", xmlNamespace );
        SecondaryOwner.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Bnfcry", xmlNamespace );
        Beneficiary.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "PwrOfAttny", xmlNamespace );
        PowerOfAttorney.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "LglGuardn", xmlNamespace );
        LegalGuardian.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "SucssrOnDth", xmlNamespace );
        SuccessorOnDeath.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Administrator is InvestmentAccountOwnershipInformation6 AdministratorValue)
        {
            writer.WriteStartElement(null, "Admstr", xmlNamespace );
            AdministratorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "OthrPty", xmlNamespace );
        OtherParty.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Grntr", xmlNamespace );
        Granter.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Sttlr", xmlNamespace );
        Settler.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static AccountParties6 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
