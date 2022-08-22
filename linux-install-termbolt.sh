#!/bin/bash
echo "Downloading Archive"
curl https://github.com/shourgamer2/TermBolt/releases/download/3.0.0/TermBolt-Linux.tar.gz --output  TermBolt-Linux.tar.gz
echo "Unzipping"
tar -xzvf TermBolt-Linux.tar.gz
echo "Some stuff to make it work!"
export DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=1
chmod u+x ./TermBolt-Linux/termbolt
echo "Everything is done now run ./TermBolt-Linux/termbolt to open termbolt!"
