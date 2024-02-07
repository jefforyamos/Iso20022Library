﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Account.  ISO2002 ID# _CXmpZlRtEe23M4WgERMsYw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.UnderlyingData1Choice;

/// <summary>
/// Reference details on the underlying account.
/// </summary>
public partial record Account : UnderlyingData1Choice_
     , IIsoXmlSerilizable<Account>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public AccountIdentification4Choice_? Identification { get; init; } 
    /// <summary>
    /// Specifies the nature, or use of the account.
    /// </summary>
    public CashAccountType2Choice_? Type { get; init; } 
    /// <summary>
    /// Identification of the currency in which the account is held. ||Usage: Currency should only be used in case one and the same account number covers several currencies|and the initiating party needs to identify which currency needs to be used for settlement on the account.
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
        if (Identification is AccountIdentification4Choice_ IdentificationValue)
        {
            writer.WriteStartElement(null, "Id", xmlNamespace );
            IdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
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
    }
    public static new Account Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
