﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReservationIdentification2.  ISO2002 ID# _Bxla1W4-EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Liquidity set aside by the account owner for specific purposes.
/// </summary>
public partial record ReservationIdentification2
     : IIsoXmlSerilizable<ReservationIdentification2>
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the reservation.
    /// </summary>
    public IsoMax35Text? ReservationIdentification { get; init; } 
    /// <summary>
    /// Identification of a particular cash clearing system.
    /// </summary>
    public SystemIdentification2Choice_? SystemIdentification { get; init; } 
    /// <summary>
    /// Nature of the reservation.
    /// </summary>
    public required ReservationType1Choice_ Type { get; init; } 
    /// <summary>
    /// Owner of the account which is being queried.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? AccountOwner { get; init; } 
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
        if (ReservationIdentification is IsoMax35Text ReservationIdentificationValue)
        {
            writer.WriteStartElement(null, "RsvatnId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ReservationIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (SystemIdentification is SystemIdentification2Choice_ SystemIdentificationValue)
        {
            writer.WriteStartElement(null, "SysId", xmlNamespace );
            SystemIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Tp", xmlNamespace );
        Type.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (AccountOwner is BranchAndFinancialInstitutionIdentification6 AccountOwnerValue)
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
    public static ReservationIdentification2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
