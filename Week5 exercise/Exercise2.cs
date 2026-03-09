void Sound(AudioClip clip)
{
    AudioSource audio = GetComponent<AudioSource>();
    audio.clip = clip;
    audio.Play();
}

void Jump()
{
    Sound(jumpSound);
    rb.velocity = Vector2.up * jumpForce;
}

void Shoot()
{
    Sound(shootSound);
    Instantiate(bullet);
}