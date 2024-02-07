﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyLockStatus1.  ISO2002 ID# _JfSv1mjMEeiRg5NzP0jkQg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Lock status of the party for processing in the system. 
/// </summary>
public partial record PartyLockStatus1
     : IIsoXmlSerilizable<PartyLockStatus1>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the date from which the lock status is valid.
    /// </summary>
    public IsoISODate? ValidFrom { get; init; } 
    /// <summary>
    /// Lock status of the party.
    /// </summary>
    public required LockStatus1Code Status { get; init; } 
    /// <summary>
    /// Specifies the underlying reason for the locking of the party.
    /// </summary>
    public IsoMax35Text? LockReason { get; init; } 
    
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
        if (ValidFrom is IsoISODate ValidFromValue)
        {
            writer.WriteStartElement(null, "VldFr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(ValidFromValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Sts", xmlNamespace );
        writer.WriteValue(Status.ToString()); // Enum value
        writer.WriteEndElement();
        if (LockReason is IsoMax35Text LockReasonValue)
        {
            writer.WriteStartElement(null, "LckRsn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(LockReasonValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static PartyLockStatus1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
