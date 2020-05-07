/*
 * Copyright (c) 2018, FusionAuth, All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
 * either express or implied. See the License for the specific
 * language governing permissions and limitations under the License.
 */


using System.Collections.Generic;
using System;

namespace io.fusionauth.domain {

  /**
   * Models an external authenticator.
   *
   * @author Trevor Smith
   */
  public class Authenticator {

    public Dictionary<string, object> data;

    public HTTPHeaders headers;

    public string httpAuthenticationPassword;

    public string httpAuthenticationUsername;

    public Guid? id;

    public DateTimeOffset? insertInstant;

    public string name;

    public Guid? sslCertificateId;

    public AuthenticatorType type;

    public string uri;

    public Authenticator with(Action<Authenticator> action) {
      action(this);
      return this;
    }
  }
}
