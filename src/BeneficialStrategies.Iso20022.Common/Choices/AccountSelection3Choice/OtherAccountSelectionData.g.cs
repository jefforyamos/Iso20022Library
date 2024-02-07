﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OtherAccountSelectionData.  ISO2002 ID# _oQaFg5TIEemqYPWMBuVawg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.AccountSelection3Choice;

/// <summary>
/// Various investment account information used to select a specific account.
/// </summary>
public partial record OtherAccountSelectionData : AccountSelection3Choice_
     , IIsoXmlSerilizable<OtherAccountSelectionData>
{
    #nullable enable
    
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    public IsoMax35Text? Name { get; init; } 
    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to be reconciled individually.
    /// </summary>
    public IsoMax35Text? Designation { get; init; } 
    /// <summary>
    /// Legal form of the fund, for example, UCITS, SICAV, OEIC, Unit Trust, and FCP.
    /// </summary>
    public IsoMax35Text? FundType { get; init; } 
    /// <summary>
    /// Name of the investment fund family.
    /// </summary>
    public IsoMax350Text? FundFamilyName { get; init; } 
    /// <summary>
    /// Detailed information about the investment fund associated to the account.
    /// </summary>
    public FinancialInstrument55? SecurityDetails { get; init; } 
    /// <summary>
    /// Owner of the account.
    /// </summary>
    public AccountOwner3Choice_? AccountOwner { get; init; } 
    /// <summary>
    /// Intermediary or other party related to the management of the account.
    /// </summary>
    public Intermediary47? Intermediary { get; init; } 
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    public PartyIdentification125Choice_? AccountServicer { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (Name is IsoMax35Text NameValue)
        {
            writer.WriteStartElement(null, "Nm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(NameValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (Designation is IsoMax35Text DesignationValue)
        {
            writer.WriteStartElement(null, "Dsgnt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(DesignationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (FundType is IsoMax35Text FundTypeValue)
        {
            writer.WriteStartElement(null, "FndTp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(FundTypeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (FundFamilyName is IsoMax350Text FundFamilyNameValue)
        {
            writer.WriteStartElement(null, "FndFmlyNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(FundFamilyNameValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        if (SecurityDetails is FinancialInstrument55 SecurityDetailsValue)
        {
            writer.WriteStartElement(null, "SctyDtls", xmlNamespace );
            SecurityDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AccountOwner is AccountOwner3Choice_ AccountOwnerValue)
        {
            writer.WriteStartElement(null, "AcctOwnr", xmlNamespace );
            AccountOwnerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Intermediary is Intermediary47 IntermediaryValue)
        {
            writer.WriteStartElement(null, "Intrmy", xmlNamespace );
            IntermediaryValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AccountServicer is PartyIdentification125Choice_ AccountServicerValue)
        {
            writer.WriteStartElement(null, "AcctSvcr", xmlNamespace );
            AccountServicerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new OtherAccountSelectionData Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
