find ../Underscore.cs -name "*.cs" -type f -exec bash -c 'unexpand -t 4 --first-only "$0" > /tmp/buff && mv /tmp/buff "$0"' {} \;
find ../Underscore.Test -name "*.cs" -type f -exec bash -c 'unexpand -t 4 --first-only "$0" > /tmp/buff && mv /tmp/buff "$0"' {} \;

