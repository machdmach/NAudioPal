H:\ws\NAudio1.7\NAudioWpfDemo\WasapiCaptureDemo\WasapiCaptureViewModel.cs

        private void Record()
        {
            try
            {
                int recordingTimeout = 60 * 60 * 1000; // 60 minutes
                Timer timer = new Timer(
                    new TimerCallback(delegate (Object state1) {
                    capture.StopRecording();
                    }), null, recordingTimeout, 0);
