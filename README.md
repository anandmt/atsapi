# A .NET Core's Simple JSON API solution for Attendance Tracking System (ATS)
Attendance Tracking System

A .NET Core web API application for ATS (attendance tracking system).

[![Build Status](https://res.cloudinary.com/dq3npvyjj/image/upload/v1586335386/passing_bnpp6y.svg)](https://github.com/anandmt/ats_desktop)
![CI](https://github.com/anandmt/ats_Vuejs/workflows/CI/badge.svg)

ATS web is a Vuejs Progressive web application, which work on any machine which is having camera inbuilt including mobile devices, it is powered with TensorflowJs Face identification library trained by  for face tracking and Azure API for accuret Face matching.


# Features!

  - Import Your picture via URL and it will get trained automatically for face match with name.
  - It Tracks and Identifies face.
  - On each encounter it changes status from Entry to Exit and vice versa. 


You can also:
  - Deploy this API on Linux server.
  - In a Doker container already hosted in docker at [atsAPI](https://atsapi.herokuapp.com/api/ats)
  

### Tech

ATS uses a number of open source projects:

* [Dotnet Core](https://github.com/dotnet/core) - The latest major release is .NET Core 3.1.
And of course ATS itself is an open source [ats](https://github.com/anandmt/ats_Vuejs) on GitHub.

### Installation

- Download the latest .NET Core SDK
# .NET Core 3.1 Releases

The following .NET Core 3.1 releases have been shipped. You must be on the latest patch release to be [supported by Microsoft](../../microsoft-support.md)

| Release Date | Description | Download |
| :-- | :-- | :--: |
| 2020/03/24 | [3.1.3](./3.1.3/3.1.3.md) | [download](https://dotnet.microsoft.com/download/dotnet-core/3.1) |

### Sample Json API response
```sh
[{"id":"5e830aa31c9d440000b91e06","name":"Anand Tiwari","image":"https://res.cloudinary.com/dq3npvyjj/image/upload/v1585571840/anand_lnkdn_yzmu5g.jpg","entry":"","exit":"","status":"enter"},{"id":"5e830aa31c9d440000b91e99","name":"Rikhil Tiwari","image":"sample/Rikhil_jfr93h.jpg","entry":"","exit":"","status":"enter"}]
```

License
----

MIT


