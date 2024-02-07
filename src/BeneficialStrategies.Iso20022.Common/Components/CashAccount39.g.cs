﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashAccount39.  ISO2002 ID# _8t9lYW48EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details to identify an account.
/// </summary>
public partial record CashAccount39
     : IIsoXmlSerilizable<CashAccount39>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public required AccountIdentification4Choice_ Identification { get; init; } 
    /// <summary>
    /// Specifies the nature, or use of the account.
    /// </summary>
    public CashAccountType2Choice_? Type { get; init; } 
    /// <summary>
    /// Identification of the currency in which the account is held.
    /// </summary>
    public ActiveOrHistoricCurrencyCode? Currency { get; init; } 
    /// <summary>
    /// Name of the account, as assigned by the account servicing institution, in agreement with the account owner in order to provide an additional means of identification of the account.||Usage: The account name is different from the account owner name. The account name is used in certain user communities to provide a means of identifying the account, in addition to the account owner's identity and the account number.
    /// </summary>
    public IsoMax70Text? Name { get; init; } 
    /// <summary>
    /// Specifies an alternate assumed name for the identification of the account. 
    /// </summary>
    public ProxyAccountIdentification1? Proxy { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public PartyIdentification135? Owner { get; init; } 
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? Servicer { get; init; } 
    
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
        writer.WriteStartElement(null, "Id", xmlNamespace );
        Identification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Type is CashAccountType2Choice_ TypeValue)
        {
            writer.WriteStartElement(null, "Tp", xmlNamespace );
            TypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Currency is ActiveOrHistoricCurrencyCode CurrencyValue)
        {
            writer.WriteStartElement(null, "Ccy", xmlNamespace );
            writer.WriteValue(CurrencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (Name is IsoMax70Text NameValue)
        {
            writer.WriteStartElement(null, "Nm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(NameValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
        if (Proxy is ProxyAccountIdentification1 ProxyValue)
        {
            writer.WriteStartElement(null, "Prxy", xmlNamespace );
            ProxyValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Owner is PartyIdentification135 OwnerValue)
        {
            writer.WriteStartElement(null, "Ownr", xmlNamespace );
            OwnerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Servicer is BranchAndFinancialInstitutionIdentification6 ServicerValue)
        {
            writer.WriteStartElement(null, "Svcr", xmlNamespace );
            ServicerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CashAccount39 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
