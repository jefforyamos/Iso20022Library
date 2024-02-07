﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstitutionIdentification18.  ISO2002 ID# _8xXCNW49EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details to identify a financial institution.
/// </summary>
public partial record FinancialInstitutionIdentification18
     : IIsoXmlSerilizable<FinancialInstitutionIdentification18>
{
    #nullable enable
    
    /// <summary>
    /// Code allocated to a financial institution by the ISO 9362 Registration Authority as described in ISO 9362 "Banking - Banking telecommunication messages - Business identifier code (BIC)".
    /// </summary>
    public IsoBICFIDec2014Identifier? BICFI { get; init; } 
    /// <summary>
    /// Information used to identify a member within a clearing system.
    /// </summary>
    public ClearingSystemMemberIdentification2? ClearingSystemMemberIdentification { get; init; } 
    /// <summary>
    /// Legal entity identifier of the financial institution.
    /// </summary>
    public IsoLEIIdentifier? LEI { get; init; } 
    /// <summary>
    /// Name by which an agent is known and which is usually used to identify that agent.
    /// </summary>
    public IsoMax140Text? Name { get; init; } 
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    public PostalAddress24? PostalAddress { get; init; } 
    /// <summary>
    /// Unique identification of an agent, as assigned by an institution, using an identification scheme.
    /// </summary>
    public GenericFinancialIdentification1? Other { get; init; } 
    
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
        if (BICFI is IsoBICFIDec2014Identifier BICFIValue)
        {
            writer.WriteStartElement(null, "BICFI", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoBICFIDec2014Identifier(BICFIValue)); // data type BICFIDec2014Identifier System.String
            writer.WriteEndElement();
        }
        if (ClearingSystemMemberIdentification is ClearingSystemMemberIdentification2 ClearingSystemMemberIdentificationValue)
        {
            writer.WriteStartElement(null, "ClrSysMmbId", xmlNamespace );
            ClearingSystemMemberIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LEI is IsoLEIIdentifier LEIValue)
        {
            writer.WriteStartElement(null, "LEI", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoLEIIdentifier(LEIValue)); // data type LEIIdentifier System.String
            writer.WriteEndElement();
        }
        if (Name is IsoMax140Text NameValue)
        {
            writer.WriteStartElement(null, "Nm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(NameValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
        if (PostalAddress is PostalAddress24 PostalAddressValue)
        {
            writer.WriteStartElement(null, "PstlAdr", xmlNamespace );
            PostalAddressValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Other is GenericFinancialIdentification1 OtherValue)
        {
            writer.WriteStartElement(null, "Othr", xmlNamespace );
            OtherValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static FinancialInstitutionIdentification18 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
