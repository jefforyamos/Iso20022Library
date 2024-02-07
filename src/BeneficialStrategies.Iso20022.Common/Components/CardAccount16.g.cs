﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardAccount16.  ISO2002 ID# _OoFisVHTEey4xOoMoOPSJQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Way to identify a customer account or a relationship to its account affected for the transaction.
/// </summary>
public partial record CardAccount16
     : IIsoXmlSerilizable<CardAccount16>
{
    #nullable enable
    
    /// <summary>
    /// Method used by the cardholder and the terminal for the choice of the account.
    /// </summary>
    public AccountChoiceMethod1Code? SelectionMethod { get; init; } 
    /// <summary>
    /// Type of cardholder account used for the transaction.
    /// </summary>
    public CardAccountType3Code? SelectedAccountType { get; init; } 
    /// <summary>
    /// Name of the account, as assigned by the account servicing institution, in agreement with the account owner in order to provide an additional means of identification of the account.
    /// Usage: The account name is different from the account owner name. The account name is used in certain user communities to provide a means of identifying the account, in addition to the account owner's identity and the account number.
    /// </summary>
    public IsoMax70Text? AccountName { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public NameAndAddress3? AccountOwner { get; init; } 
    /// <summary>
    /// Identification of the currency in which the account is held.
    /// </summary>
    public ActiveCurrencyCode? Currency { get; init; } 
    /// <summary>
    /// Unique identifier of the account, as assigned by the account servicer.
    /// </summary>
    public AccountIdentification54Choice_? AccountIdentifier { get; init; } 
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    public PartyIdentification177Choice_? Servicer { get; init; } 
    
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
        if (SelectionMethod is AccountChoiceMethod1Code SelectionMethodValue)
        {
            writer.WriteStartElement(null, "SelctnMtd", xmlNamespace );
            writer.WriteValue(SelectionMethodValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (SelectedAccountType is CardAccountType3Code SelectedAccountTypeValue)
        {
            writer.WriteStartElement(null, "SelctdAcctTp", xmlNamespace );
            writer.WriteValue(SelectedAccountTypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (AccountName is IsoMax70Text AccountNameValue)
        {
            writer.WriteStartElement(null, "AcctNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(AccountNameValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
        if (AccountOwner is NameAndAddress3 AccountOwnerValue)
        {
            writer.WriteStartElement(null, "AcctOwnr", xmlNamespace );
            AccountOwnerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Currency is ActiveCurrencyCode CurrencyValue)
        {
            writer.WriteStartElement(null, "Ccy", xmlNamespace );
            writer.WriteValue(CurrencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (AccountIdentifier is AccountIdentification54Choice_ AccountIdentifierValue)
        {
            writer.WriteStartElement(null, "AcctIdr", xmlNamespace );
            AccountIdentifierValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Servicer is PartyIdentification177Choice_ ServicerValue)
        {
            writer.WriteStartElement(null, "Svcr", xmlNamespace );
            ServicerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CardAccount16 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
