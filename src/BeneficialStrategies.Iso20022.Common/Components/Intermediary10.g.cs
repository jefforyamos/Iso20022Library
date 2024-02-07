﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Intermediary10.  ISO2002 ID# _QOV8Bdp-Ed-ak6NoX_4Aeg_1509055223.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party that provides services to investors relating to financial products.
/// </summary>
public partial record Intermediary10
     : IIsoXmlSerilizable<Intermediary10>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of the intermediary.
    /// </summary>
    public required PartyIdentification2Choice_ Identification { get; init; } 
    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    public Account7? Account { get; init; } 
    /// <summary>
    /// Function performed by the intermediary.
    /// </summary>
    public InvestmentFundRole2Code? Role { get; init; } 
    /// <summary>
    /// Function performed by the intermediary.
    /// </summary>
    public IsoExtended350Code? ExtendedRole { get; init; } 
    /// <summary>
    /// Contact person and contact information.
    /// </summary>
    public ContactIdentification2? ContactPerson { get; init; } 
    
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
        if (Account is Account7 AccountValue)
        {
            writer.WriteStartElement(null, "Acct", xmlNamespace );
            AccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Role is InvestmentFundRole2Code RoleValue)
        {
            writer.WriteStartElement(null, "Role", xmlNamespace );
            writer.WriteValue(RoleValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ExtendedRole is IsoExtended350Code ExtendedRoleValue)
        {
            writer.WriteStartElement(null, "XtndedRole", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoExtended350Code(ExtendedRoleValue)); // data type Extended350Code System.String
            writer.WriteEndElement();
        }
        if (ContactPerson is ContactIdentification2 ContactPersonValue)
        {
            writer.WriteStartElement(null, "CtctPrsn", xmlNamespace );
            ContactPersonValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Intermediary10 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
