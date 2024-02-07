﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountAndBalance4.  ISO2002 ID# _QSzlR9p-Ed-ak6NoX_4Aeg_237043718.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides account and balance information.
/// </summary>
public partial record AccountAndBalance4
     : IIsoXmlSerilizable<AccountAndBalance4>
{
    #nullable enable
    
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    public required IsoMax35Text SafekeepingAccount { get; init; } 
    /// <summary>
    /// Balance to which the payment applies (less or equal to the total eligible balance).
    /// </summary>
    public required BalanceFormat1Choice_ ConfirmedBalance { get; init; } 
    
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
        writer.WriteStartElement(null, "SfkpgAcct", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(SafekeepingAccount)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "ConfdBal", xmlNamespace );
        ConfirmedBalance.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static AccountAndBalance4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
