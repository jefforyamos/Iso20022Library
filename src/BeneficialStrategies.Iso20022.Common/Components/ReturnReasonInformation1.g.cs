﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReturnReasonInformation1.  ISO2002 ID# _TPKBpdp-Ed-ak6NoX_4Aeg_2976420.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Further information on the return reason of the transaction.
/// </summary>
public partial record ReturnReasonInformation1
     : IIsoXmlSerilizable<ReturnReasonInformation1>
{
    #nullable enable
    
    /// <summary>
    /// Party issuing the return.
    /// </summary>
    public PartyIdentification8? ReturnOriginator { get; init; } 
    /// <summary>
    /// Specifies the reason for the return.
    /// </summary>
    public ReturnReason1Choice_? ReturnReason { get; init; } 
    /// <summary>
    /// Further details on the return reason.
    /// </summary>
    public IsoMax105Text? AdditionalReturnReasonInformation { get; init; } 
    
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
        if (ReturnOriginator is PartyIdentification8 ReturnOriginatorValue)
        {
            writer.WriteStartElement(null, "RtrOrgtr", xmlNamespace );
            ReturnOriginatorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReturnReason is ReturnReason1Choice_ ReturnReasonValue)
        {
            writer.WriteStartElement(null, "RtrRsn", xmlNamespace );
            ReturnReasonValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalReturnReasonInformation is IsoMax105Text AdditionalReturnReasonInformationValue)
        {
            writer.WriteStartElement(null, "AddtlRtrRsnInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax105Text(AdditionalReturnReasonInformationValue)); // data type Max105Text System.String
            writer.WriteEndElement();
        }
    }
    public static ReturnReasonInformation1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
