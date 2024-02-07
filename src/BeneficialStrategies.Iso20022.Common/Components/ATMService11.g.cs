﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMService11.  ISO2002 ID# _fRt8wa3-EeWL1uap3dNhCQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Deposit service provided by the ATM inside the session.
/// </summary>
public partial record ATMService11
     : IIsoXmlSerilizable<ATMService11>
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the deposit service provided by the ATM inside the session.
    /// </summary>
    public IsoMax35Text? ServiceReference { get; init; } 
    /// <summary>
    /// Codification of the type of service for the ATM.
    /// </summary>
    public IsoMax35Text? ATMServiceCode { get; init; } 
    /// <summary>
    /// Describes the type of deposit service selected by the customer.
    /// </summary>
    public required ATMServiceType6Code ServiceType { get; init; } 
    /// <summary>
    /// Identification of the variant of the service.
    /// </summary>
    public IsoMax35Text? ServiceVariantIdentification { get; init; } 
    /// <summary>
    /// True if deposit with cash back transaction.
    /// </summary>
    public IsoTrueFalseIndicator? CashBack { get; init; } 
    /// <summary>
    /// True if the deposit transaction is split in multiple accounts.
    /// </summary>
    public IsoTrueFalseIndicator? MultiAccount { get; init; } 
    
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
        if (ServiceReference is IsoMax35Text ServiceReferenceValue)
        {
            writer.WriteStartElement(null, "SvcRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ServiceReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ATMServiceCode is IsoMax35Text ATMServiceCodeValue)
        {
            writer.WriteStartElement(null, "ATMSvcCd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ATMServiceCodeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SvcTp", xmlNamespace );
        writer.WriteValue(ServiceType.ToString()); // Enum value
        writer.WriteEndElement();
        if (ServiceVariantIdentification is IsoMax35Text ServiceVariantIdentificationValue)
        {
            writer.WriteStartElement(null, "SvcVarntId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ServiceVariantIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (CashBack is IsoTrueFalseIndicator CashBackValue)
        {
            writer.WriteStartElement(null, "CshBck", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(CashBackValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (MultiAccount is IsoTrueFalseIndicator MultiAccountValue)
        {
            writer.WriteStartElement(null, "MultiAcct", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(MultiAccountValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
    }
    public static ATMService11 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
