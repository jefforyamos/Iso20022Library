﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TaxParty1.  ISO2002 ID# _PdBMxtp-Ed-ak6NoX_4Aeg_-1937885674.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details about the entity involved in the tax paid or to be paid.
/// </summary>
public partial record TaxParty1
     : IIsoXmlSerilizable<TaxParty1>
{
    #nullable enable
    
    /// <summary>
    /// Tax identification number of the creditor.
    /// </summary>
    public IsoMax35Text? TaxIdentification { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
    /// </summary>
    public IsoMax35Text? RegistrationIdentification { get; init; } 
    /// <summary>
    /// Type of tax payer.
    /// </summary>
    public IsoMax35Text? TaxType { get; init; } 
    
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
        if (TaxIdentification is IsoMax35Text TaxIdentificationValue)
        {
            writer.WriteStartElement(null, "TaxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(TaxIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (RegistrationIdentification is IsoMax35Text RegistrationIdentificationValue)
        {
            writer.WriteStartElement(null, "RegnId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(RegistrationIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (TaxType is IsoMax35Text TaxTypeValue)
        {
            writer.WriteStartElement(null, "TaxTp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(TaxTypeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static TaxParty1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
