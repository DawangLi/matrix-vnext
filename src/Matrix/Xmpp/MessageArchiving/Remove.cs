/*
 * Copyright (c) 2003-2017 by AG-Software <info@ag-software.de>
 *
 * All Rights Reserved.
 * See the COPYING file for more information.
 *
 * This file is part of the MatriX project.
 *
 * NOTICE: All information contained herein is, and remains the property
 * of AG-Software and its suppliers, if any.
 * The intellectual and technical concepts contained herein are proprietary
 * to AG-Software and its suppliers and may be covered by German and Foreign Patents,
 * patents in process, and are protected by trade secret or copyright law.
 *
 * Dissemination of this information or reproduction of this material
 * is strictly forbidden unless prior written permission is obtained
 * from AG-Software.
 *
 * Contact information for AG-Software is available at http://www.ag-software.de
 */

using System;
using Matrix.Attributes;
using Matrix.Xml;

namespace Matrix.Xmpp.MessageArchiving
{
    [XmppTag(Name = "remove", Namespace = Namespaces.Archiving)]
    public class Remove : XmppXElement
    {
        #region Schema
        /*
          <xs:element name='remove'>
            <xs:complexType>
              <xs:simpleContent>
                <xs:extension base='empty'>
                  <xs:attribute name='end' type='xs:dateTime' use='optional'/>
                  <xs:attribute name='exactmatch' type='xs:boolean' use='optional'/>
                  <xs:attribute name='open' use='optional' type='xs:boolean'/>
                  <xs:attribute name='start' type='xs:dateTime' use='required'/>
                  <xs:attribute name='with' type='xs:string' use='required'/>
                </xs:extension>
              </xs:simpleContent>
            </xs:complexType>
          </xs:element>
         */
        #endregion

        public Remove() : base(Namespaces.Archiving, "remove")
        {
        }

        public Jid With
        {
            get { return GetAttributeJid("with"); }
            set { SetAttribute("with", value); }
        }

        public DateTime Start
        {
            get { return GetAttributeIso8601Date("start"); }
            set { SetAttributeIso8601Date("start", value); }
        }

        public DateTime End
        {
            get { return GetAttributeIso8601Date("end"); }
            set { SetAttributeIso8601Date("end", value); }
        }

        public bool ExactMatch
        {
            get { return GetAttributeBool("exactmatch"); }
            set { SetAttribute("exactmatch", value); }
        }

        public bool Open
        {
            get { return GetAttributeBool("open"); }
            set { SetAttribute("open", value); }
        }
    }
}
