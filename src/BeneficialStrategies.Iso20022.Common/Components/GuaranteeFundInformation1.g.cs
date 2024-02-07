﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for GuaranteeFundInformation1.  ISO2002 ID# __ATdACchEeaBPexHR4QTEw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Owner and account number of the guarantee fund.
/// </summary>
public partial record GuaranteeFundInformation1
     : IIsoXmlSerilizable<GuaranteeFundInformation1>
{
    #nullable enable
    
    /// <summary>
    /// Guarantee fund account identifier.
    /// </summary>
    public required CashAccount24 GuaranteeFundAccount { get; init; } 
    /// <summary>
    /// Owner identification of the guarantee fund.
    /// </summary>
    public required FinancialInstitutionIdentification9 GuaranteeFundAccountOwner { get; init; } 
    
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
        writer.WriteStartElement(null, "GrntFndAcct", xmlNamespace );
        GuaranteeFundAccount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "GrntFndAcctOwnr", xmlNamespace );
        GuaranteeFundAccountOwner.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static GuaranteeFundInformation1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
