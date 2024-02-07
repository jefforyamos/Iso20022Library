﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReservationSearchCriteria2.  ISO2002 ID# _8IaeM6MgEeCJ6YNENx4h-w_-54648369.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to search for a reservation.
/// </summary>
public partial record ReservationSearchCriteria2
     : IIsoXmlSerilizable<ReservationSearchCriteria2>
{
    #nullable enable
    
    /// <summary>
    /// Identification of a particular cash clearing system.
    /// </summary>
    public SystemIdentification2Choice_? SystemIdentification { get; init; } 
    /// <summary>
    /// Type of reservation as set by default in the system. The default reservation is applicable by the system unless otherwise instructed.
    /// </summary>
    public ReservationType1Code? DefaultReservationType { get; init; } 
    /// <summary>
    /// Type of reservation applied by the system at the present time.
    /// </summary>
    public ReservationType1Code? CurrentReservationType { get; init; } 
    /// <summary>
    /// Owner of the account which is being queried.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5? AccountOwner { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public AccountIdentification4Choice_? AccountIdentification { get; init; } 
    
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
        if (SystemIdentification is SystemIdentification2Choice_ SystemIdentificationValue)
        {
            writer.WriteStartElement(null, "SysId", xmlNamespace );
            SystemIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DefaultReservationType is ReservationType1Code DefaultReservationTypeValue)
        {
            writer.WriteStartElement(null, "DfltRsvatnTp", xmlNamespace );
            writer.WriteValue(DefaultReservationTypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (CurrentReservationType is ReservationType1Code CurrentReservationTypeValue)
        {
            writer.WriteStartElement(null, "CurRsvatnTp", xmlNamespace );
            writer.WriteValue(CurrentReservationTypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (AccountOwner is BranchAndFinancialInstitutionIdentification5 AccountOwnerValue)
        {
            writer.WriteStartElement(null, "AcctOwnr", xmlNamespace );
            AccountOwnerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AccountIdentification is AccountIdentification4Choice_ AccountIdentificationValue)
        {
            writer.WriteStartElement(null, "AcctId", xmlNamespace );
            AccountIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static ReservationSearchCriteria2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
