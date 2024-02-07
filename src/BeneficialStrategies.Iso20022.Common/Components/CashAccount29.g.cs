﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashAccount29.  ISO2002 ID# _Dob-MR6iEeOolf0-cMYhrw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information used for identifying an account.
/// </summary>
public partial record CashAccount29
     : IIsoXmlSerilizable<CashAccount29>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the account between the account owner and the account servicer.
    /// </summary>
    public required CashAccountIdentification1Choice_ Identification { get; init; } 
    /// <summary>
    /// Institution that maintains the records where the account is held.
    /// </summary>
    public FinancialInstitutionIdentification3Choice_? AccountServicer { get; init; } 
    
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
        if (AccountServicer is FinancialInstitutionIdentification3Choice_ AccountServicerValue)
        {
            writer.WriteStartElement(null, "AcctSvcr", xmlNamespace );
            AccountServicerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CashAccount29 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
